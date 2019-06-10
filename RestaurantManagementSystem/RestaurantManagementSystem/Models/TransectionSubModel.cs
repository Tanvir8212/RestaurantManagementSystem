using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class TransectionSubModel
    {
        public long Id { get; set; }
        public int FoodItemId { get; set; }
        public String FoodItemName { get; set; }
        public int Quantity { get; set; }

        
        public long TransectionId { get; set; }
        [ForeignKey("TransectionId")]
        public Transection Transection { get; set; }
    }
}