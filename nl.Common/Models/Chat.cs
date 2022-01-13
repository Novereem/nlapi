using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class Chat
    {
        [Key] public Guid Id { get; set; }
        public List<Message> Messages { get; set; }
        
        public string AccountId { get; set; }

        public Chat()
        {
            Id = Guid.NewGuid();
            Messages = new List<Message>();
        }
    }
}