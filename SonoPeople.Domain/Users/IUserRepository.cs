﻿using SonoPeople.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoPeople.Domain.Users
{
    public interface IUserRepository: IRepository<User, int>
    {

    }
}
