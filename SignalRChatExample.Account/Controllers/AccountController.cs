using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SignalRChatExample.Account.Database.Models;
using SignalRChatExample.Account.Models;
using SignalRChatExample.Account.Requests;

namespace SignalRChatExample.Account.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/signup")]
        public async Task<IActionResult> Signup(ApplicationUser user, Credentials credentials)
        {
            return await _mediator.Send(new SignupRequest(user, credentials));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login(Credentials credentials)
        {
            return await _mediator.Send(new LoginRequest(credentials, Request));
        }

        [HttpPost]
        public async Task<IActionResult> Logout(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
