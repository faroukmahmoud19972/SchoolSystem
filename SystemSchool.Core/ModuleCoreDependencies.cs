using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SystemSchool.Core
{
    public  static class ModuleCoreDependencies
    {
        public static IServiceCollection AddeCoreDependencies(this IServiceCollection services)
        {
            // Configuration Of Mediator : 
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));


            //Configuration Of AutoMapper : 
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }


    }
}