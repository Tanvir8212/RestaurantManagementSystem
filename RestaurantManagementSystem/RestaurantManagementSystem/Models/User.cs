using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantManagementSystem.Models
{
    public class User
    {
        public long Id { get; set; }
        public String Password { get; set; }
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public UserType UserType { get; set; }

    }
}