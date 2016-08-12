using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.DAL.Redis.DatabaseContainer
{
    public interface IDatabaseContainer
    {
        IDatabase GetDb();
        void Store(IDatabase db);
    }
}
