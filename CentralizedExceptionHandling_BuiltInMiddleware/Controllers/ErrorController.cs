using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentralizedExceptionHandling_BuiltInMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("/error")]
        public IActionResult HandleError()
        {
            var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();
                var exception = exceptionHandlerFeature?.Error;
            return Problem(
                statusCode: StatusCodes.Status500InternalServerError,
                title: exception?.Message
               
                );
        }
    }
}

               