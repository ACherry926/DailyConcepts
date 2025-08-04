using Day27Concepts.Model;
using Day27Concepts.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// Services without Dependency Injection
        /// </summary>

        private readonly ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody]ProductModel product)
        {
            _productRepository.AddProduct(product);
            var products = _productRepository.GetAllProducts();
            
            return Ok(products);
        }




        /// <summary>
        /// Resolve the service Dependency
        /// this is the how resolve DI directly in the ActionMethod Insteded of using Constructor everytime
        /// </summary>
        [HttpGet("name")]
        public IActionResult GetName([FromServices] IProductsRepository _productsRepository)
        {
            var name = _productsRepository.GetName();

            return Ok(name);
        }
    }
}
