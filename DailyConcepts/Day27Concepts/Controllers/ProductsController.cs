using Day27Concepts.Model;
using Day27Concepts.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Day27Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /// <summary>
        /// Services with Dependency Injection
        /// Transient : Every Request creates a new instance
        /// Scoped : Once per request
        /// SingleTon : Create only once
        /// </summary>
        private readonly IProductsRepository _productsRepository;
        private readonly IProductsRepository _productsRepository1;

        public ProductsController(IProductsRepository productsRepository, 
            IProductsRepository productsRepository1)
        {
            _productsRepository = productsRepository;
            _productsRepository1 = productsRepository1;
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _productsRepository.AddProduct(product);
            var products = _productsRepository1.GetAllProducts();

            return Ok(products);
        }

        [HttpGet("")]
        public IActionResult GetName()
        {
            var name = _productsRepository.GetName();

            return Ok(name);
        }
    }
}
