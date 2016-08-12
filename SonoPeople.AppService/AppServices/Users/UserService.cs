using AutoMapper;
using SonoPeople.AppService.ViewModels;
using SonoPeople.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.AppService.AppServices
{
    public class UserService : IUserService
    {
        private IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<UserViewModel> GetAllUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User() {
                Id=1,
                Email = "a@a.com",
                CreatedOn = DateTime.Now,
                IsActivated = true
            });
            users.Add(new User()
            {
                Id = 2,
                Email = "b@b.com",
                CreatedOn = DateTime.Now,
                IsActivated = true
            });

            List<UserViewModel> usersVm = _mapper.Map<List<User>, List<UserViewModel>>(users);
            return usersVm;
        }
    }
}
