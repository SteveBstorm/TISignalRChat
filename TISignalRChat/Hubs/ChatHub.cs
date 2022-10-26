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
            message.ConnectionId = Context.ConnectionId;
            _chatDB.AddMessage(message);
            await Clients.All.SendAsync("receiveMessage", message);
        }

        public async Task SendMessageToGroup(Message message, string groupName)
        {
            await Clients.Group(groupName).SendAsync("fromGroup"+groupName, message);
        }

        public async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await SendMessageToGroup(
                new Message
                {
                    Sender = "System",
                    Time = DateTime.Now,
                    Content = Context.ConnectionId + " has joined " + groupName,
                }
                , groupName);
        }
    }
}
