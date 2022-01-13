using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        
        public List<WishList> Saved { get; set; }

        public Account(string email, string username, string password)
        {
            Email = email;
            Username = username;
            Password = password;
            Saved = new List<WishList>();
        }
    }
}