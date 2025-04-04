using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace stock.management.services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetProductDetails()
        {
            return Ok(new
            {
                ProductId = 1,
                ProductName = "Sample Product",
                Quantity = 100
            });
        }
    }
}
