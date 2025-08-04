using Day27Concepts.Model;
using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    /// <summary>
    /// FromBody is used to bind the data available in Body
    /// Example : https://localhost:44366/api/FromBody/12
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FromBodyController : ControllerBase
    {
        [HttpPost("{id}")]
        public IActionResult AddCountry([FromRoute]int id ,[FromBody] CountryModel country)
        {
            return Ok($"Name ={country.Name}, Population ={country.Population}");
        }
    }
}
