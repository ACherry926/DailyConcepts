using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataBindingGetController : ControllerBase
    {
        /// <summary>
        /// DataBinding with QueryString Example
        /// </summary>
        //[HttpGet("")]
        //public IActionResult AddCountry(string name, int area  )
        //{
        //    return Ok($"Name ={name}");
        //}

        /// <summary>
        /// DataBinding with passing data in url Example
        /// </summary>
        [HttpGet("{name}/{area}")]
        public IActionResult AddCountry(string name, int area)
        {
            return Ok($"Name ={name}");
        }
    }
}
