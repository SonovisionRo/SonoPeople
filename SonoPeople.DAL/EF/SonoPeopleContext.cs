using Microsoft.EntityFrameworkCore;
using SonoPeople.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.DAL.EF
{
    public class SonoPeopleContext: DbContext
    {
        public SonoPeopleContext(DbContextOptions<SonoPeopleContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}
