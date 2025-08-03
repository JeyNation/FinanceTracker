using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using FinanceTracker.Contract.User;

namespace FinanceTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            // Registration logic here
            return Ok();
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Login logic here
            return Ok();
        }

        [Authorize]
        [HttpGet("Profile")]
        public IActionResult GetProfile()
        {
            // Get current user info logic here
            return Ok();
        }

        [Authorize]
        [HttpPut("Profile")]
        public IActionResult UpdateProfile([FromBody] UpdateProfileRequest request)
        {
            // Update current user info logic here
            return Ok();
        }
    }
}