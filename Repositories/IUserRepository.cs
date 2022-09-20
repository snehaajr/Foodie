﻿using Models;
using UserModel;

namespace Repositories
{
    public interface IUserRepository
    {
        bool AddUser(User u);
        List<Item> GetItem(string id);
    }
}