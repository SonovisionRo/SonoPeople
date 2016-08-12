using System;
using Microsoft.Extensions.DependencyInjection;

namespace SonoPeople.CompositionRoot
{
    internal class PersistenceProviderLoaderFactory
    {
        
        internal static IProviderLoderStrategy LoadProviders( string providerType)
        {
            IProviderLoderStrategy providerStrategy=null;
            switch (providerType)
            {
                case "Redis":
                    providerStrategy = new RedisProviderLoaderStrategy();
                    break;
            }
            return providerStrategy;
        }
    }
}