using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.SignalR;
using NieuweLaptopApi.Hubs.Clients;
using nl.Commen.Models;
using nl.Logic;

namespace NieuweLaptopApi.Hubs
{
    
    /*
     [EnableCors]
     public class ChatHub : Hub
    {
        
        private readonly ChatService _chatService;
        public async Task Joined(string name)
        {
            await Groups.AddToGroupAsync(name, "chat");
        }

        public async Task ChatMessage(string message)
        {
            //_chatService.SaveChatMessage(message);
            await Clients.All.SendAsync("NewMessage", message);
        }
        
    }*/
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}