using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
namespace Repositories
{
    public class AdminRepo : IAdminRepo
    {

        private readonly AdminContext adminContext;
        public AdminRepo(AdminContext a) {
            adminContext = a;
        }
        public List<RestaurantRequest> GetRestaurantRequest()
        {
            
                List<RestaurantRequest> rr = adminContext.RestaurantRequest.ToList<RestaurantRequest>();
                return rr;
            
        }
        public List<Restaurant> GetMainRestaurants()
        {

            List<Restaurant> rs = adminContext.MainRestaurantList.ToList<Restaurant>();
          
            return rs;

        }
        public List<Feedback> GetFeedbacks()
        {

            List<Feedback>f = adminContext.Feedback.ToList<Feedback>();

            return f;


        }
        public string Verified(int id,int value)
        {
            List<RestaurantRequest> rr = adminContext.RestaurantRequest.ToList<RestaurantRequest>();
            RestaurantRequest restaurantRequest=null;
            for (int i = 0; i < rr.Count; i++)
            {
                if (rr[i].RestaurantRequestId == id)
                   restaurantRequest = rr[i];
            }
            if (restaurantRequest == null)
                return "update rejected";
            if (value == 1)
            {
                restaurantRequest.isVerified = true;
                adminContext.RestaurantRequest.Update(restaurantRequest);
               
                adminContext.MainRestaurantList.Add(new Restaurant(restaurantRequest.RestaurantName,restaurantRequest.Location,0, restaurantRequest.RestaurantOwnerEmailID));
              
         
            }
            else
            {
                restaurantRequest.isVerified = false;
                adminContext.RestaurantRequest.Update(restaurantRequest);
                 adminContext.MainRestaurantList.Remove(new Restaurant(restaurantRequest.RestaurantName,restaurantRequest.RestaurantId,  restaurantRequest.Location, 0, restaurantRequest.RestaurantOwnerEmailID));
     

            }
           adminContext.SaveChangesAsync();

            return "updated3";
        }

        public string PostFeedBacks(Feedback fb)
        {
            adminContext.Feedback.Add(fb);
            adminContext.SaveChanges();
            return "posted";

        }

        /*public List<Feedback> PostFeedBacks()
        {
            throw new NotImplementedException();
        }*/
    }
}
