using Lab2.Data;
using Lab2.Models.Filters;
using Lab2.Repositries.Implementions;
using Lab2.Repositries.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            builder.Services.AddDbContext<AppDBContext>();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Account/Register";
                options.AccessDeniedPath = "/Account/AccessDenied";
            });

            var app = builder.Build();

            //Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //====================================================================
            // my middlewares
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middle 1 - Part 1\n");
            //    await next.Invoke();
            //    await context.Response.WriteAsync("Middel 1 - Part 2\n");
            //}
            //);

            // app.Run(async (context) => await context.Response.WriteAsync("Run Middle\n"));

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middle 2 - Part1\n");
            //    await next.Invoke();
            //    await context.Response.WriteAsync("Middle 2 - Part2\n");
            //});
            // ====================================================================


            app.Run();
        }
    }
}
