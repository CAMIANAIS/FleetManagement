using FleetManagement.Application.DTOs;
using FleetManagement.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace FleetManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
        {
            var token = await _userService.LoginAsync(request.Email, request.Password);

            if (token == null)
            {
                return Unauthorized(new { message = "Credenciales inválidas." });
            }

            // Si es exitoso, devolvemos el token
            return Ok(new { Token = token });
        }
    }
}
