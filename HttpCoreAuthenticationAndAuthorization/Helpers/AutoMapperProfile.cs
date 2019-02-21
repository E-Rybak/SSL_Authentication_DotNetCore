using HttpCoreAuthenticationAndAuthorization.Dtos;
using HttpCoreAuthenticationAndAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpCoreAuthenticationAndAuthorization.Helpers
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            // User map
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            // Role map
            CreateMap<Role, RoleDto>();
            CreateMap<RoleDto, Role>();

            // RoleUser map
            CreateMap<RolerUser, RoleUserDto>();
            CreateMap<RoleUserDto, RolerUser>();
        }
    }
}
