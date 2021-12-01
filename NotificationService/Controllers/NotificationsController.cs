using Microsoft.AspNetCore.Mvc;
using NotificationService.Services;

namespace NotificationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly RabbitMqService _service;
        public NotificationsController(RabbitMqService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetMessage()
        {
            return Ok();
        }
    }
}
