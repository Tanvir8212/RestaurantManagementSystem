using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class FoodCategory
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public List<FoodItem> FoodItems { get; set; }
    }
}