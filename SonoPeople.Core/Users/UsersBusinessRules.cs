using SonoPeople.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoPeople.Core.Users
{
    public class UsersBusinessRules
    {
        public static readonly BusinessRule EmailRequired 
            = new BusinessRule("Email", "Email is required.");
        public static readonly BusinessRule EmailSonovisionDomain
    = new BusinessRule("Email", "Email must be in sonovision domain.");
    }
}
