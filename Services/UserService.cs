using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;

namespace Services
{
    public class UserService : IUserService
    {
        IUserRepository r;
        public UserService(IUserRepository v)
        {

            r = v;
        }
        public bool RegisterUser(User u)
        {
            r.AddUser(u);
            return true;
        }
    }
}
