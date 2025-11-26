using Microsoft.AspNetCore.Mvc;

namespace Shatably.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class test : ControllerBase
    {
        [HttpGet]
        public IActionResult t()
        {
            return Ok();
        }
    }
}
