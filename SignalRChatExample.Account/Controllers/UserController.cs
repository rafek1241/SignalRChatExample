using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SignalRChatExample.Account.Requests;

namespace SignalRChatExample.Account.Controllers
{
    [Authorize]
    public class UserController
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/self")]
        public async Task<IActionResult> GetCurrentUserInfo()
        {
            return await _mediator.Send(new CurrentUserInfoRequest());
        }

    }
}
