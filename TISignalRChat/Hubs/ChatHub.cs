using Microsoft.AspNetCore.SignalR;
using TISignalRChat.DataContext;
using TISignalRChat.Models;

namespace TISignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private FakeChatDB _chatDB;

        public ChatHub(FakeChatDB chatDB)
        {
            _chatDB = chatDB;
        }

        public async Task SendMessage(Message message)
        {
            _chatDB.AddMessage(message);
            await Clients.All.SendAsync("receiveMessage", message);
        }
    }
}
