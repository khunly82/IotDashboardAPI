using IotDashboardAPI.Dto;
using IotDashboardAPI.Hubs.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IotDashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmergencyController(ISensorsNotifier sensorsNotifier) : ControllerBase
    {
        [HttpPost]
        public IActionResult EmergencyCall([FromBody] EmergencyCallDto dto)
        {
            sensorsNotifier.NotifyEmergencyAsync(dto.Room);
            return Created();
        }
    }
}
