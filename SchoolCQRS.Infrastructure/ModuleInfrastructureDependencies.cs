using Microsoft.Extensions.DependencyInjection;
using SchoolCQRS.Infrastructure.Interfaces;
using SchoolCQRS.Infrastructure.Repository;

namespace SchoolCQRS.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }

    }
}
