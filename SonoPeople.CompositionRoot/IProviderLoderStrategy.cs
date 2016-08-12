using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.CompositionRoot
{
    interface IProviderLoderStrategy
    {
        void LoadRepositories(IServiceCollection serviceCollection);
    }
}
