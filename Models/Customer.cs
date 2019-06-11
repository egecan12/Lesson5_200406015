using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson5_200406015.Models
{
    public class Customer
    {
        public int CustomerId {get; set;}
        [Required]
        public String Name { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String Phone { get; set; }
        [EmailAddress]
        public String email { get; set; }
    }
}