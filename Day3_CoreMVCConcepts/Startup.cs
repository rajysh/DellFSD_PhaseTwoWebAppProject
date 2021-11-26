using Day3_CoreMVCConcepts.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day3_CoreMVCConcepts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            /**********Creating IEmployeeRepository instance as dependency injection **********/
            services.Add(new ServiceDescriptor(typeof(IEmployeeRepository), new EmployeeRepository())); //By Default Singleton

            //services.Add(new ServiceDescriptor(typeof(IEmployeeRepository), typeof(EmployeeRepository), ServiceLifetime.Singleton));
            //services.Add(new ServiceDescriptor(typeof(IEmployeeRepository), typeof(EmployeeRepository), ServiceLifetime.Transient));
            //services.Add(new ServiceDescriptor(typeof(IEmployeeRepository), typeof(EmployeeRepository), ServiceLifetime.Scoped));

            /* Application service with extension methods */
            //services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            //services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
