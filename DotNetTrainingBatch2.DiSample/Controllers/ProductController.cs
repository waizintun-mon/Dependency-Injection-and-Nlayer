using DotNetTrainingBatch2.DiSample.Database.AppDbContextModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch2.DiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly IConfiguration _configuration;
        public ProductController(AppDbContext db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
           var lst = _db.TblProducts.Where(x => x.DeleteFlag == false).ToList();
            return Ok(lst);
        }
        [HttpGet("GetConnectionStr")]
        public IActionResult GetConnectionString()
        {
            var str = _configuration.GetConnectionString("DbConnection");
            return Ok(str);
        }
    }
}
