using CustomerService.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly RabbitMqService _service;
        public CustomerController(RabbitMqService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] string message)
        {
            _service.Send(message);
            return Ok();
        }
    }
}
