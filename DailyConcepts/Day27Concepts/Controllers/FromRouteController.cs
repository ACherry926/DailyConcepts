using Day27Concepts.Model;
using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    /// <summary>
    /// FromRoute is used to bind the data available in Route(URl)
    /// Example :https://localhost:44366/api/FromRoute/Aravind/12/523?id=51
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FromRouteController : ControllerBase
    {
        [HttpPost("{name}/{population}/{Area}")]
        public IActionResult AddCountry([FromRoute] CountryModel country, [FromQuery] int id)
        {
            return Ok($"Name ={country.Name}, Population ={country.Population}");
        }

    }
}
