using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext()
            : base("Name=RestaurantManagementDB")
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Transection> Transections { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
    }
}