using System;
using System.Security.Principal;

namespace SignalRChatExample.Hubs.Chat.Models
{
    public class ChatMessage
    {
        public long MessageId { get; set; }

        public string Message { get; set; }

        public IPrincipal Author { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
