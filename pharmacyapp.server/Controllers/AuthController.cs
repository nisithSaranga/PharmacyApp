using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using pharmacyapp.server.Data;
using pharmacyapp.server.Models;

namespace pharmacyapp.server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly PharmacyContext _context;
        public AuthController(PharmacyContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] pharmacyapp.server.Models.LoginRequest request)

        {
            // Check username and password (your existing logic)
            var user = _context.Users.SingleOrDefault(u => u.Username == request.Username && u.Password == request.Password);

            if (user == null)
                return Unauthorized();

            // Generate token (if any), or just use a fake one for now
            var token = "demo-token"; // Or your real JWT here

            // **RETURN username and role now:**
            return Ok(new
            {
                token = token,
                username = user.Username,
                role = user.Role   // <-- Make sure your User entity/table has a Role column!
            });
        }

    }
}
