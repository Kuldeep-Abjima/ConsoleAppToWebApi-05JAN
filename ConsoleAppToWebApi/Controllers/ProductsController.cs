using ConsoleAppToWebApi.Models;
using ConsoleAppToWebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReposiotry _productRepository;
        private readonly IProductReposiotry _productRepository1;
        public ProductsController(IProductReposiotry productRepository, IProductReposiotry productReposiotry1)
        {
            _productRepository = productRepository;
            _productRepository1 = productReposiotry1;
        }
        [HttpPost("")]
        public IActionResult AddProduct([FromBody] ProductModel products)
        {
            _productRepository.AddProduct(products);
            var product = _productRepository1.GetAllProducts();
            return Ok(product);
        }
        [HttpGet("")]
        public IActionResult GetName()
        {
            var product = _productRepository.GetName();
            return Ok(product);
        }
    } 
}
