using System;
using System.ComponentModel.DataAnnotations;

namespace nl.Commen.Models
{
    public class Message
    {
        [Key] public Guid Id { get; set; }
        public string SenderName { get; set; }
        public string Text { get; set; }

        public Message(string senderName, string text)
        {
            Id = Guid.NewGuid();
            SenderName = senderName;
            Text = text;
        }
    }
}