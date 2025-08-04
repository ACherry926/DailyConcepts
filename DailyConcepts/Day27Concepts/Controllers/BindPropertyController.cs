using Day27Concepts.Model;
using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BindPropertyController : ControllerBase
    {
        [BindProperty]
        public CountryModel Country { get; set; }

        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name ={this.Country.Name}, " +
                $"Population= {this.Country.Population}, " +
                $"Area = {this.Country.Area}");
        }
    }
}
