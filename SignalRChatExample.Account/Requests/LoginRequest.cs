using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRChatExample.Account.Models;

namespace SignalRChatExample.Account.Requests
{
    public class LoginRequest : IRequest<IActionResult>
    {
        public Credentials Credentials { get; set; }

        public AppDomain Domain { get; set; }

        public HttpRequest Request { get; set; }

        public LoginRequest(Credentials credentials, HttpRequest request)
        {
            Domain = AppDomain.CurrentDomain;
            Request = request;
        }
    }
}
