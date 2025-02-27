using Lab2.DataAccess.Data;
using Lab2.DataAccess.Repositry;
using Lab2.Entities.Interfaces;
using Lab2.Entities.Mapper;
using Microsoft.EntityFrameworkCore;

namespace Lab2.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            // Register DBContext
            builder.Services.AddDbContext<AppDBContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Register UnitOfWork
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Register AutoMapper
            builder.Services.AddAutoMapper(typeof(MapperConfig));

            // CROS 
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", policy =>
                {
                    policy.AllowAnyOrigin()  
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI(option => option.SwaggerEndpoint("/openapi/v1.json", "v1"));
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowSpecificOrigin");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
