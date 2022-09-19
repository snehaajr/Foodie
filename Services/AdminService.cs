﻿using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AdminService : IAdminService
    {
        IAdminRepo adminRepo;
        public AdminService(IAdminRepo ar)
        {
            this.adminRepo = ar;
        }
        public List<RestaurantRequest> GetRestaurantRequest()
        {
            return adminRepo.GetRestaurantRequest();
        }
        public List<Restaurant> GetMainRestaurants()
        {
            return adminRepo.GetMainRestaurants();

        }
        public string Verified(int id,int value)
        {
           return adminRepo.Verified(id,value);
        }

        public List<Feedback> GetFeedbacks()
        {
            return adminRepo.GetFeedbacks();
        }
        public string PostFeedBacks(Feedback feedback)
        {
            return adminRepo.PostFeedBacks(feedback);
        }
    }
}
