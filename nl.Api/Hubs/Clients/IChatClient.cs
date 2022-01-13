using System.Threading.Tasks;
using nl.Commen.Models;

namespace NieuweLaptopApi.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}