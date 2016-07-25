using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SonoPeople.Core.Users;

namespace SonoPeople.Tests.Core.Users
{
    [TestClass]
    public class UsersTests
    {
        [TestMethod]
        public void GetBrokenRules_EmailNotFilled_returns_EmailRequired()
        {
            //arrange
            User user = new User() {
                CreatedOn = DateTime.Now,
                IsActivated = false            
            };
            //act
           var brokenRules = user.GetBrokenRules().ToList();
            var emailRequiredRule = brokenRules.FirstOrDefault(r => r.Property == "Email");
            //assert

            Assert.IsNotNull(emailRequiredRule);
        }

        [TestMethod]
        public void GetBrokenRules_EmailIsNotSonoDomain_returns_EmailSonovisionDomain_rule()
        {
            //arrange
            User user = new User()
            {
                CreatedOn = DateTime.Now,
                Email="a@a.com",
                IsActivated = false
            };
            //act
            var brokenRules = user.GetBrokenRules().ToList();
            var emailRequiredRule = brokenRules.FirstOrDefault(r => r.Equals(UsersBusinessRules.EmailSonovisionDomain));
            //assert

            Assert.IsNotNull(emailRequiredRule);
        }
    }
}
