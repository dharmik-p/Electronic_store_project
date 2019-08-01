using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Electronic_store.Models
{
    public class Appliance
    {
        public int Id { get; set; }
        [Required]
        public string Catagory { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Brand { get; set; }
    }
}