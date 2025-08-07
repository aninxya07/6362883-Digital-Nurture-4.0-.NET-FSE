using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        // Only JWTs that contain "Admin" in their role claim can access this
        [HttpGet("dashboard")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAdminDashboard()
        {
            return Ok("Welcome to the Admin Dashboard. Only admins can see this.");
        }

        // Anyone with valid JWT, regardless of role
        [HttpGet("common")]
        [Authorize]
        public IActionResult GetCommonDashboard()
        {
            return Ok("This is accessible to any authenticated user.");
        }
    }
}