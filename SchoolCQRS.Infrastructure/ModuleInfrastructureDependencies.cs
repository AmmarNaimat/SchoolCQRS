using Microsoft.Extensions.DependencyInjection;
using SchoolCQRS.Infrastructure.InfrastructureBases;
using SchoolCQRS.Infrastructure.Interfaces;
using SchoolCQRS.Infrastructure.Repository;

namespace SchoolCQRS.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;
        }

    }
}
