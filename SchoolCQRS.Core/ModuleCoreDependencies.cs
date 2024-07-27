using Microsoft.Extensions.DependencyInjection;
using SchoolCQRS.Core.Features.Students.Queries.Models;
using SchoolCQRS.Core.Features.Students.StudentFactoryImplementation;
using SchoolCQRS.Core.Features.Students.StudentFactoryInterfaces;
using System.Reflection;

namespace SchoolCQRS.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(med => med.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()))
                .AddSingleton<GetStudentsQuery>()
                .AddTransient<IStudentFactory, StudentFactory>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
