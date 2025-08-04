using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties(SupportsGet = true)]
    public class BindPropertiesGetController : ControllerBase
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public int Area { get; set; }

        [HttpGet("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name ={this.Name}, " +
                $"Population= {this.Population}, " +
                $"Area = {this.Area}");
        }
    }
}
