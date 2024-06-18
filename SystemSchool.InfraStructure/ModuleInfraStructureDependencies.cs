using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Data.Entities;
using SystemSchool.InfraStructure.Abstracts;
using SystemSchool.InfraStructure.InfraStructureBases;
using SystemSchool.InfraStructure.Repositories;

namespace SystemSchool.InfraStructure
{
    public static class ModuleInfraStructureDependencies
    {
        public static IServiceCollection AddInfraStructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();

            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            return services;
        }

    }
}