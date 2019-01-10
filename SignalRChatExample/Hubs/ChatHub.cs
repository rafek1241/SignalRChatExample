using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChatExample.Hubs
{
    public class ChatHub : Hub
    {
        public async Task NewMessage(string username, string messageContent)
        {
            await Clients.All.SendAsync("messageReceived", username, messageContent);
        }
    }
}
