using Microsoft.Extensions.DependencyInjection;
using SchoolCQRS.Core.Features.Students.Queries.Models;
using System.Reflection;

namespace SchoolCQRS.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(med => med.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())).AddSingleton<GetStudentsQuery>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
