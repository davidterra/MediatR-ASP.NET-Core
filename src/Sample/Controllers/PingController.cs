using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PingController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PingController(IMediator mediator) 
            => _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new Ping("Pong"));
            return Ok(response);
        }
    }
}