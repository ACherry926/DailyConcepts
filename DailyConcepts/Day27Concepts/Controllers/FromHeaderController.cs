using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FromHeaderController : ControllerBase
    {
        [HttpPost("{id}")]
        public IActionResult AddCountry([FromRoute] int id, [FromHeader] string developer, [FromHeader] string course)
        {
            return Ok($"Name ={developer}");
        }
    }
}
