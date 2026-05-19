using Application.DTOs;
using Application.Interfaces;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class AuthController : ControllerBase
{
    private readonly IJwtService _jwtService;

    public AuthController(IJwtService jwtService)
    {
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        if (dto.Username != "admin" || dto.Password != "admin123")
        {
            return Unauthorized("Invalid username or password");
        }

        var token = _jwtService.GenerateToken(dto.Username);

        return Ok(new
        {
            Token = token
        });
    }
}