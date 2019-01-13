using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using SignalRChatExample.Hubs.Chat.Events;
using SignalRChatExample.Hubs.Chat.Models;

namespace SignalRChatExample.Hubs.Chat
{
    public class ChatHub : Hub
    {
        private readonly IMediator _mediator;

        public ChatHub(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task NewMessage(ChatMessage message)
        {
            //Inform server-side instance about event
            await _mediator.Publish(new NewMessageNotification(message));

            //Inform client-side instances about event
            await Clients.All.SendAsync("messageReceived", message);
        }
    }
}
