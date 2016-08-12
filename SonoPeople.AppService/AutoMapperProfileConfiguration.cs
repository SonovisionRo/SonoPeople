using AutoMapper;
using SonoPeople.AppService.ViewModels;
using SonoPeople.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.AppService
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration():base()
        {
            CreateMap<User, UserViewModel>();
        }        
    }
}
