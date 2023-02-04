using AutoMapper;
using Core.Services;
using Domain.DTO.Authorization;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SelfStudy.Controllers;

[ApiController]
[Route("api/[controller]/Registration")]

public class AuthorizationsController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IAuthorizationService _service;
    private readonly IValidator<CreateUserDto> _validator;
    private readonly IValidator<ConfirmationDto> _confirmationValidator;

    public AuthorizationsController(IMapper mapper,IAuthorizationService service,IValidator<CreateUserDto> validator
    ,IValidator<ConfirmationDto> confirmationValidator)
    {
        _mapper = mapper;
        _service = service;
        _validator = validator;
        _confirmationValidator = confirmationValidator;
    }
    
    [SwaggerOperation(Summary = "Registers new user in our system")]
    [SwaggerResponse(201, "Returns information about registered user", typeof(string))]
    [HttpPost]
    public async Task<IActionResult> RegisterUsersAsync([FromBody] CreateUserDto userDto)
    {
        var validationResult = await _validator.ValidateAsync(userDto);
        if (validationResult.IsValid is false)
        {
             validationResult.AddToModelState(this.ModelState);
                        return BadRequest(ModelState);
        }

        var result = await _service.RegisterUserAsyc(userDto);
        
        return Ok();
    }
    
    [SwaggerOperation(Summary = "Confirm Registered user")]
    [SwaggerResponse(200, "Returns Jwt token for user", typeof(string))]
    [HttpPut]
    public async Task<IActionResult> ConfirmUsersAsync([FromBody] ConfirmationDto confirmationDto)
    {
        var vaildationResult = await _confirmationValidator.ValidateAsync(confirmationDto);
        if (vaildationResult.IsValid == false)
        {
            vaildationResult.AddToModelState(this.ModelState);
                return BadRequest(ModelState);
        }

        var result = await _service.ConfirmUserAsyc(confirmationDto);
        return Ok();
    }
}
