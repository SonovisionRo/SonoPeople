using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.DAL.Redis.DatabaseContainer
{
    public class HttpDatabaseContainer : IDatabaseContainer
    {
       // private string _dataContextKey = "RedisDatabase";

        public IDatabase GetDb()
        {
            return null;
        }

        public void Store(IDatabase db)
        {            
        }
    }
}
