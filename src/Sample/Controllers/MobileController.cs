using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers
{
    [ApiController]
    [Route("api/mobile")]
    public class MobileController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MobileController(IMediator mediator) => this._mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
           await _mediator.Publish(new Mobile("999999999")); 
           return Ok();
        }
    }
}