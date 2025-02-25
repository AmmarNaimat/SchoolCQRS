
using SchoolCQRS.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using SchoolCQRS.Infrastructure;
using SchoolCQRS.Service;
using SchoolCQRS.Core;
using SchoolCQRS.Core.Features.Students.Queries.Models;

namespace SchoolCQRS.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AppDBContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("schoolConnectionString"));
            });
            builder.Services
                .AddInfrastructureDependencies()
                .AddServiceDependencies()
                .AddCoreDependencies();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
