using AutoMapper;
using Core.DTO.Authorization;
using Core.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SelfStudy.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AuthorizationsController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IAuthorizationService _service;
    private readonly IValidator<CreateUserDto> _validator;

    public AuthorizationsController(IMapper mapper,IAuthorizationService service,IValidator<CreateUserDto> validator)
    {
        _mapper = mapper;
        _service = service;
        _validator = validator;
    }
    
    [SwaggerOperation(Summary = "Registers new user in our system")]
    [SwaggerResponse(201, "Returns information about registered user", typeof(string))]
    [HttpPost("Registration")]
    public async Task<IActionResult> RegisterUsersAsync([FromBody] CreateUserDto userDto)
    {
        var validationResult = await _validator.ValidateAsync(userDto);
        if (validationResult.IsValid is false)
        {
             validationResult.AddToModelState(this.ModelState);
                        return BadRequest(ModelState);
        }

        return Ok();
    }
    
    [SwaggerOperation(Summary = "Confirm Registered user")]
    [SwaggerResponse(200, "Returns Jwt token for user", typeof(string))]
    [HttpPut("Registration")]
    public async Task<IActionResult> ConfirmUsersAsync([FromBody] ConfirmationDto confirmationDto)
    {
        return Ok();
    }
}
