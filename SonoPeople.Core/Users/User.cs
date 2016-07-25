using SonoPeople.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoPeople.Core.Users
{
    public class User : EntityBase<int>
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public bool IsActivated { get; set; }
        public DateTime CreatedOn { get; set; }        
        protected override void Validate()
        {
            if
        }
    }
}
