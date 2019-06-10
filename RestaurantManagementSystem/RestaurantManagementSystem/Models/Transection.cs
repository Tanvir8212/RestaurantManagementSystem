using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class Transection
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; }
        
        public double TotalPrice { get; set; }
        public Discount Discount { get; set; }

        public List<TransectionSubModel> TransectionSubModels { get; set; }
    }
}