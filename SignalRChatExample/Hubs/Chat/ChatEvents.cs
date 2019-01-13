using MediatR;
using SignalRChatExample.Hubs.Chat.Models;

// ReSharper disable once CheckNamespace
namespace SignalRChatExample.Hubs.Chat.Events
{
    public class NewMessageNotification : INotification
    {
        public NewMessageNotification(ChatMessage message)
        {
            Message = message;
        }

        public ChatMessage Message { get; set; }
    }
}
