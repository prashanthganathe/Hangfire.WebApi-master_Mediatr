using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire.WebApi.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hangfire.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatrCQSController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MediatrCQSController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpPost]
        public IActionResult PostOrder(OrderRequestModel order)
        {
            var response = _mediator.Send(order);
            return Ok(response);


        }
    }
}
