using TISignalRChat.Models;

namespace TISignalRChat.DataContext
{
    public class FakeChatDB
    {
        private List<Message> messages;

        public FakeChatDB()
        {
            messages = new List<Message>();
        }

        public void AddMessage(Message m)
        {
            messages.Add(m);
        }

        public List<Message> GetMessages()
        {
            return messages;
        }
    }
}
