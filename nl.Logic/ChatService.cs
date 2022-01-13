using nl.Commen.Interfaces;

namespace nl.Logic
{
    public class ChatService
    {
        private readonly IChatData _chatData;
        
        public ChatService(IChatData chatData)
        {
            _chatData = chatData;
        }

        public void SaveChatMessage(string message)
        {
            _chatData.SaveChatMessage(message);
        }
    }
}