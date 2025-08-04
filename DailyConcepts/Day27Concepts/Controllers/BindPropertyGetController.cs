using Day27Concepts.Model;
using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BindPropertyGetController : ControllerBase
    {
        [BindProperty(SupportsGet = true)]
        public CountryModel Country { get; set; }

        [HttpGet("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name ={this.Country.Name}, " +
                $"Population= {this.Country.Population}, " +
                $"Area = {this.Country.Area}");
        }
    }
}
