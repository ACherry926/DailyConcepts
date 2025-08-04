using Microsoft.AspNetCore.Mvc;

namespace Day26Concepts.Controllers
{
    /// <summary>
    /// Route Constraints
    /// </summary> 
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("{id:int:min(10):max(100)}")]
        public string GetById(int id)
        {
            return "hello int " + id;
        }

        [HttpGet("{id}")]
        public string GetByString(string id)
        {
            return "hello string " + id;
        }

        /// <summary>
        /// MinLength Example
        /// </summary>        
        [HttpGet("{id:minlength(5)}")]
        public string GetByMinLength(string id)
        {
            return "hello string " + id;
        }

        /// <summary>
        /// Alpha Example & Length 
        /// </summary>        
        [HttpGet("{id:length(5):alpha}")]
        public string GetByAlpha(string id)
        {
            return "hello string " + id;
        }

        /// <summary>
        /// Regex Example 
        /// </summary>        
        [HttpGet("{id:regex(a(b|c))}")]
        public string GetByIdRegex(string id)
        {
            return "hello Regex " + id;
        }
    }
}
