using Microsoft.AspNetCore.Mvc;
using SharedKernel.Filters;


namespace Services.Api
{
    [ApiController]
    [ApiResultFilter]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseController : ControllerBase
    {        public bool UserIsAutheticated => HttpContext.User.Identity.IsAuthenticated;
    }
}
