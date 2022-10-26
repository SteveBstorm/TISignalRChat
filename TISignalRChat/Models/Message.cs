namespace TISignalRChat.Models
{
    public class Message
    {
        public string Sender { get; set; }
        public string? ConnectionId { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
    }
}
