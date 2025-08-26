using DotNetTrainingBatch2.DiSample.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch2.DiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductV2Controller : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductV2Controller(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{pageNo}/{pageSize}")]
        public IActionResult GetProducts(int pageNo,int pageSize)
        {
            var lst = _productService.GetProducts(pageNo, pageSize);
            return Ok(lst);
        }
    }
}
