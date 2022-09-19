using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RestaurantContext _rc;
        public RestaurantRepository(RestaurantContext r)
        {
            _rc = r;
        }
        public string PostRestaurantReq(RestaurantRequest r)
        {
            if (r != null)
            {
                _rc.RestaurantRequest.Add(r);
                _rc.SaveChanges();
                return "updated";
            }
            else
            {
                return "No value";
            }
        }
    }
}
