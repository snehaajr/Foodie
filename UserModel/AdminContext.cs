using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options) : base(options)
        {
        }

        public AdminContext()
        {

        }
        public DbSet<RestaurantRequest>RestaurantRequest { get; set; }
        public DbSet<Restaurant> MainRestaurantList { get; set; }
        public DbSet<Feedback> Feedback { get; set; }

    }
}
