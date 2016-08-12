using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.Infrastructure.Domain
{
    public class SonoPeopleException : Exception
    {
        public SonoPeopleException()
        {
        }

        public SonoPeopleException(string message) : base(message)
        {
        }

        public SonoPeopleException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
