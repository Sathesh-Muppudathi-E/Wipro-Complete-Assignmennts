using AutoMapper;
using TrainingManagementSystem.DTOs;
using TrainingManagementSystem.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUserDto, User>();
        CreateMap<UpdateUserDto, User>();
    }
}
