using AutoMapper;
using Core.Services;
using Domain.DTO.Authentication;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SelfStudy.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationsController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IAuthenticationService _authenticationService;
    public AuthenticationsController(IMapper mapper,IAuthenticationService authenticationService)
    {
        _mapper = mapper;
        _authenticationService = authenticationService;
    }
    [SwaggerOperation(Summary = "Log in user in our system")]
    [SwaggerResponse(200, "Returns jwt token for user", typeof(string))]
    [HttpPost("Login")]
    public async Task<IActionResult> LoginUsersAsync(LoginDto loginDto)
    {
        return Ok();
    }
    
    [SwaggerOperation(Summary = "Changing password of existing user.")]
    [SwaggerResponse(200, "Returns new jwt token for user", typeof(string))]
    [HttpPost("Change Password")]
    public async Task<IActionResult> ChangePasswordAsync()
    {
        return Ok();
    }
    
    [SwaggerOperation(Summary = "Changing email of existing user.")]
    [SwaggerResponse(200, "Returns new jwt token for user", typeof(string))]
    [HttpPost("Change Email")]
    public async Task<IActionResult> ChangeEmailAsync()
    {
        return Ok();
    }
    
}