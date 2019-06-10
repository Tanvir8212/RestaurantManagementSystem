using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public String PromoCode { get; set; }
        public String Name { get; set; }
        public double DiscountPersentage { get; set; }
        public double DiscountAmount { get; set; }
        public String Description { get; set; }
        public DateTime Validity { get; set; }
    }
}