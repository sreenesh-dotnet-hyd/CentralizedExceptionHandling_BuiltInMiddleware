using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentralizedExceptionHandling_BuiltInMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            throw new Exception("testing an exception");
        }
    }
}
