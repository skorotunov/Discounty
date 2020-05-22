using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Discounty.WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
        protected readonly IMediator Mediator;

        public ApiController(IMediator mediator)
        {
            Mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
    }
}
