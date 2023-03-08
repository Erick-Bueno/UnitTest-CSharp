namespace Product.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpPost]
        public async Task<ActionResult<productModel>> Post([FromBody] productModel prod)
        {
            var create = await productService.Create(prod);
            return Ok(create);
        }
    }
}