using SonoPeople.Domain.Users;
using SonoPeople.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SonoPeople.Infrastructure.Domain;
using StackExchange.Redis;

namespace SonoPeople.DAL.Redis
{
    public class UserRepository : Repository<User, int>, IUserRepository
    {        

        public UserRepository(IUnitOfWork uow, IDatabase db): base(uow)
        {
           
        }
        public void PersistCreationOf(IAggregateRoot entity)
        {
           
        }

        public void PersistDeletionOf(IAggregateRoot entity)
        {
            throw new NotImplementedException();
        }

        public void PersistUpdateOf(IAggregateRoot entity)
        {
            throw new NotImplementedException();
        }
    }
}
