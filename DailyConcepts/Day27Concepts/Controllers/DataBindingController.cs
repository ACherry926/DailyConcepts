using Day27Concepts.Model;
using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    /// <summary>
    /// DataBinding HttpPost method with Complex Type Example
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DataBindingController : ControllerBase
    {
        [HttpPost("")]
        public IActionResult AddCountry(CountryModel country)
        {
            return Ok($"Name ={country.Name}");
        }
    }
}
