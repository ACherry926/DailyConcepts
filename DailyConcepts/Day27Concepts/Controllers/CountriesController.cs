using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    /// <summary>
    /// Data Binding
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int Population { get; set; }

        [BindProperty]
        public int Area { get; set; }

        //[HttpPost("")]
        //public IActionResult AddCountry()
        //{
        //    return Ok(this.Name);
        //}

        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name ={this.Name}, Population= {this.Population}, Area = {this.Area}");
        }   
    }
}
