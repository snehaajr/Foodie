using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Restaurant
    {
        public Restaurant()
        {

        }
        public Restaurant(string restaurantName, string location, int v, string restaurantOwnerEmailID)
        {
            RestaurantName = restaurantName;
           
            Location = location;
            rating = v;
            RestaurantOwnerEmailID = restaurantOwnerEmailID;
        }
        public Restaurant(string restaurantName,int restaurantId ,string location, int v, string restaurantOwnerEmailID)
        {
            RestaurantName = restaurantName;
            RestaurantId = restaurantId;
            Location = location;
            rating = v;
            RestaurantOwnerEmailID = restaurantOwnerEmailID;
        }

        public int Name { get; set; }
        [Key]
        public int RestaurantId { get; set; }
        public string Location { get; set; }
      
        public int rating { get; set; }
        public string RestaurantOwnerEmailID { get; set; }
        public string RestaurantName { get; set; }
    }
}