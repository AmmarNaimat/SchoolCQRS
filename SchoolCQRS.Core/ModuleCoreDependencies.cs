using Microsoft.Extensions.DependencyInjection;
using SchoolCQRS.Core.Features.Students.Queries.Models;
using SchoolCQRS.Service.Implementation;
using SchoolCQRS.Service.Interfaces;
using System.Reflection;

namespace SchoolCQRS.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(med => med.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())).AddSingleton<GetStudentsQuery>();
            return services;
        }
    }
}
