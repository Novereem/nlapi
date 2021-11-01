using System;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class Laptop
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}