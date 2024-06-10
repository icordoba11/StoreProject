using Microsoft.AspNetCore.Mvc;
using Negocio.Entities;
using Negocio.Interfaces;
using Negocio.Persistence;


namespace Negocio.Controllers
{
    [ApiController]
    [Route("negocio/[controller]")]

    public class NegocioController : Controller
    {
        readonly IProductService _productService;
        readonly IProductRepository _productRepository;

        public NegocioController(IProductService productService, IProductRepository productRepository)
        {
            _productService = productService;
            _productRepository = productRepository;
        }

        [HttpGet("InsertProduct")]

        public IActionResult InsertProduct()
        {
            var product = _productService.CreateDefaultProduct();

            _productRepository.InsertProduct(product);

            return Ok("Producto agregado correctamente");
        }

        [HttpGet("SearchProduct")]

        public IActionResult SearchProduct()
        {

            var product = _productService.SearchProduct();

            return Ok(product);
        }

    }
}
