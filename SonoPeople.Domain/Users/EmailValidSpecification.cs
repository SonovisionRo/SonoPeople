using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SonoPeople.Domain.Users
{
    public class EmailValidSpecification
    {
        private static Regex _emailregex = new Regex(@"\w+([-+.]\w+)*@sonovisiongroup\.com");
        public bool IsSatisfiedBy(string email) {
            return _emailregex.IsMatch(email);
        }
    }
}
