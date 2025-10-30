using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentralizedExceptionHandling_BuiltInMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test([FromRoute] int a, [FromRoute] int b)
        {
            return Ok(a / b);
        }
    }
}
