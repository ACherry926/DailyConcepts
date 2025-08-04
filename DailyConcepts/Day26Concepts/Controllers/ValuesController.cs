using Microsoft.AspNetCore.Mvc;

namespace Day26Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Routing Example
        /// [Route("api/get-all")]
        /// [Route("getall")]
        /// [Route("get-all")]
        /// </summary>
        [HttpGet("~/get-all")]
        public string GetAll()
        {
            return "hello from get all";
        }

        [HttpGet("~/get-all-authors")]
        //[Route("[controller]/[action]")]
        //[Route("getall")] this is not possible
        public string GetAllAuthors()
        {
            return "hello from get all authors";
        }

        /// <summary>
        /// Variables in Routing
        /// [Route("book/{id}")]
        /// </summary>

        [HttpGet]
        [Route("~/book/{id}")]
        public string GetById(int id)
        {
            return "hello " + id;
        }

        [HttpGet]
        [Route("~/book/{id}/author/{authorId}")]
        public string GetAuthorAdressById(int id, int authorId)
        {
            return "hello author address " + id + " " + authorId;
        }

        /// <summary>
        /// Query String in Routing
        /// [Route("search")]
        /// Pass value like this --search?name=Aravind&id=20
        /// </summary>
        [HttpGet("~/search")]
        public string SearchBook(int id, int authorId, string name, int rating, int price)
        {
            return "hello from search";
        }


        /// <summary>
        /// Setup Multile URLs for single Resource(Action method)
        /// [Route("[controller]/[action]")]
        /// </summary>

        /// <summary>
        /// Setup the Base Route at the controller level
        /// [Route("[controller]/[action]")]
        /// </summary>
    }
}
