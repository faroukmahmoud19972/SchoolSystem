using Microsoft.Extensions.DependencyInjection;
using SystemSchool.InfraStructure.Abstracts;
using SystemSchool.InfraStructure.Repositories;

namespace SystemSchool.InfraStructure
{
    public static class ModuleInfraStructureDependencies
    {
        public static IServiceCollection AddInfraStructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }

    }
}