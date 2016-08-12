using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SonoPeople.Domain.Users;

namespace SonoPeople.CompositionRoot
{
    public class RedisProviderLoaderStrategy : IProviderLoderStrategy
    {
        public void LoadRepositories(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped <IUserRepository, SonoPeople.DAL.Redis.UserRepository > ();
        }
    }
}
