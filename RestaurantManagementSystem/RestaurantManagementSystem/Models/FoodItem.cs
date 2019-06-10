using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public String Description { get; set; }


        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual FoodCategory Category { get; set; }

    }
}