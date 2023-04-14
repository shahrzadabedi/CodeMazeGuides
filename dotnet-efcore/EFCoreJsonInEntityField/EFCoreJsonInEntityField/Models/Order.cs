﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EFCoreJsonInEntityField.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        
        [Required]
        public string CustomerName { get; set; }
        
        [Required]
        public ShippingInfo ShippingInfo{ set; get; }        
    }
}
