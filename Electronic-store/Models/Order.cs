using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Electronic_store.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int prise { get; set; }
        [Required]
        public int Customer_Id { get; set; }
        [Required]
        public int Appliance_Id { get; set; }
    }
}