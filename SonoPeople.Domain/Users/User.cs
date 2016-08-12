using SonoPeople.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoPeople.Domain.Users
{
    public class User : EntityBase<int>, IAggregateRoot
    {     

        public string Email { get; set; }
        public bool IsActivated { get; set; }
        public DateTime CreatedOn { get; set; }        
        protected override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {                
                AddBrokenRule(UsersBusinessRules.EmailRequired);
            }
            else
            {
                if (! new EmailValidSpecification().IsSatisfiedBy(Email))
                {
                    AddBrokenRule(UsersBusinessRules.EmailSonovisionDomain);
                }
            }
        }
    }
}
