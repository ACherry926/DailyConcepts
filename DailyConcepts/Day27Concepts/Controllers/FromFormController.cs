using Day27Concepts.Model;
using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    /// <summary>
    /// FromForm is used to bind the data available in Form
    /// Example : https://localhost:44366/api/FromForm/12
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FromFormController : ControllerBase
    {
        [HttpPost("{id}")]
        public IActionResult AddCountry([FromRoute] int id, [FromForm] CountryModel country)
        {
            return Ok($"Name ={country.Name}, Population ={country.Population}");
        }
    }
}
