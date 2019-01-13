using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignalRChatExample.Account.Models;
using SignalRChatExample.Account.Requests;

namespace SignalRChatExample.Account.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Login(Credentials credentials)
        {
            return await _mediator.Send(new LoginRequest(credentials, Request));
        }
    }
}
