using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties]
    public class BindPropertiesController : ControllerBase
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public int Area { get; set; }

        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name ={this.Name}, " +
                $"Population= {this.Population}, " +
                $"Area = {this.Area}");
        }
    }
}
