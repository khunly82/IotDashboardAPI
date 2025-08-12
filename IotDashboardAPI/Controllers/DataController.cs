using IotDashboardAPI.Dto;
using IotDashboardApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IotDashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController(DataService dataService) : ControllerBase
    {
        // data/42 // FromRoute
        // data?limit=42 // FromQuery
        [HttpGet]
        public IActionResult Get([FromQuery][Required][Range(0, 10000)]int limit) 
        {
            return Ok(dataService.GetLastDatas(limit));
        }

        [HttpPost]
        public IActionResult Post([FromBody] AddDataDto dto) 
        {
            dataService.AddData(dto.Date, dto.Temperature, dto.Humidity);
            return Created();
        }
    }
}
