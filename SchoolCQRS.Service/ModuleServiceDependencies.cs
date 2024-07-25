using Microsoft.Extensions.DependencyInjection;
using SchoolCQRS.Infrastructure.Interfaces;
using SchoolCQRS.Infrastructure.Repository;
using SchoolCQRS.Service.Implementation;
using SchoolCQRS.Service.Interfaces;

namespace SchoolCQRS.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}
