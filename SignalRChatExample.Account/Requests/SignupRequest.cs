using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRChatExample.Account.Database.Models;
using SignalRChatExample.Account.Models;

namespace SignalRChatExample.Account.Requests
{
    public class SignupRequest : IRequest<IActionResult>
    {
        public ApplicationUser User { get; }
        public Credentials Credentials { get; }

        public SignupRequest(ApplicationUser user, Credentials credentials)
        {
            User = user;
            Credentials = credentials;
        }
    }
}
