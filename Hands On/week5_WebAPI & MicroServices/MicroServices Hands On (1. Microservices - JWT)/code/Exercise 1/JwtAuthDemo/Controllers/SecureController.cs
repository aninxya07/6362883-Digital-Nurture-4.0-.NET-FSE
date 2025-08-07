using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [HttpGet("data")]
        public IActionResult GetSecureData()
        {
            return Ok("You have accessed a protected endpoint!");
        }
    }
}