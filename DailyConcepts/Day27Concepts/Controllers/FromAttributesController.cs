using Day27Concepts.Model;
using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    /// <summary>
    /// FromQuery is used to bind the data available in query string
    /// Example : api/FromAttributes?name=India&area=25
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FromAttributesController : ControllerBase
    {
        [HttpPost("")]
        public IActionResult AddCountry([FromQuery] int id ,[FromQuery]CountryModel country)
        {
            return Ok($"Name ={country.Name}, Population ={country.Population}");
        }

    }
}
