using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class WishList
    {
        [Key]
        public Guid Id { get; set; }
        public List<Laptop> Laptops { get; set; } 
    }
}