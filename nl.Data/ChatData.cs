using System.Collections.Generic;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Data
{
    public class ChatData : IChatData
    {
        private readonly INlContext _nlContext;
        public ChatData(INlContext nlContext)
        {
            _nlContext = nlContext;
        }
        public void SaveChatMessage(string message)
        {
            
        }
    }
}