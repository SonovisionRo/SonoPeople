using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using SonoPeople.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SonoPeople.AppService.AppServices;
using AutoMapper;
using SonoPeople.AppService;

namespace SonoPeople.CompositionRoot
{
    public class DependencyMapper
    {
        public static void SetDependencies(IServiceCollection serviceCollection, IConfigurationRoot configuration)
        {
            serviceCollection.AddEntityFramework()
                             .AddDbContext<SonoPeopleContext>(options =>
                                                            options.UseSqlServer(configuration["Data:DefaultConnection:ConnectionString"])
                                                            );            

            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfileConfiguration());
            });
            serviceCollection.AddSingleton<IMapper>(sp => mapperConfiguration.CreateMapper());

            serviceCollection.AddScoped<IUserService, UserService>();

        }
    }
}
