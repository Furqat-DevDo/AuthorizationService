using AutoMapper;
using Domain.DTO.Authorization;
using Domain.Entities;
using Domain.Models;

namespace Core.Mappers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CreateUserDto,UserModel>();
        CreateMap<UserModel, GetUserDto>();
        CreateMap<UserModel, User>();
        CreateMap<User, UserModel>();
    }
   
}