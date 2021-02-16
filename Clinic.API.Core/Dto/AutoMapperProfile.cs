using AutoMapper;
using Clinic.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Dto
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>()
                       .ForAllMembers(m => m.Condition((source, target, sourceValue, targetValue) => sourceValue != null));
            CreateMap<User, UserDto>()
                        .ForMember(u => u.Role, opt => opt.MapFrom(src => src.Role.RoleName))
                        .ForMember(u => u.CountryName, opt => opt.MapFrom(src => src.Country.CountryName))
                        .ForMember(u =>u.CityName, opt => opt.MapFrom(src => src.City.CityName))
                        .ForMember(u => u.Status, opt => opt.MapFrom(src => src.Status.Status));

            CreateMap<UserDto, User>();
        }
    }
}
