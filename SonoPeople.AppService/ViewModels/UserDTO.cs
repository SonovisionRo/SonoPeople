using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.AppService.ViewModels
{
    public class UserViewModel: VMBase
    {
        public string Email { get; set; }
        public bool IsActivated { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
