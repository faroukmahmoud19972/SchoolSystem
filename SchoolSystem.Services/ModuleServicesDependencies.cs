using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Services.Abstracts;
using SchoolSystem.Services.Implementations;
using SystemSchool.InfraStructure.Abstracts;
using SystemSchool.InfraStructure.Repositories;

namespace SchoolSystem.Services
{
    public static class ModuleServicesDependencies
    {
        public static IServiceCollection AddModuleServicesDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }


    }
}