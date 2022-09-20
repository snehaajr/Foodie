using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using UserModel;
//using Models.FoodieContext;
namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FoodieContext _fc;
        public UserRepository(FoodieContext f)
        {
            _fc = f;
        }
        public bool AddUser(User u)
        {
            if (u != null)
            {
                _fc.Users.Add(u);
                _fc.SaveChanges();
                return true;
            }
            return false;

            
        }


        public List<Item> GetItem(string id)
        {
            List<Item> items = _fc.Item.ToList();
            List<Item> ritems=new List<Item>();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].RestaurantId == id)
                {
                    ritems.Add(items[i]);
                }
            }
            return ritems;
        }

        //public bool ValidateUser(User u)
        //{
        //    if ((_userService.ValidateUser))
        //}


    }
}
