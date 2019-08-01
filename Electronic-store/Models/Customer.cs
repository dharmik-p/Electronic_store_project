using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Electronic_store.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        

    }
}