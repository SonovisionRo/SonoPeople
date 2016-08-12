using SonoPeople.AppService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.AppService.AppServices
{
    public interface IUserService
    {
        List<UserViewModel> GetAllUsers();
    }
}
