using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreWebAppBasic.DAL;

namespace NetCoreWebAppBasic
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            //Configuration = configuration;
            try
            {
                var builder = new ConfigurationBuilder();
                if (env.IsDevelopment())
                {
                    builder.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: false, reloadOnChange: true)
                    //.AddJsonFile(Path.Combine("sharedsettings.json"), optional: false, reloadOnChange: true)
                    //.AddJsonFile(Path.Combine($"sharedsettings.{env.EnvironmentName}.json"), optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables();
                }
                else//env.EnvironmentName
                {
                    var RootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..");
                    Console.WriteLine("RootPath : " + RootPath);
                    builder.SetBasePath(RootPath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: false, reloadOnChange: true)
                    //.AddJsonFile("sharedsettings.json", optional: false, reloadOnChange: true)
                    //.AddJsonFile($"sharedsettings.{env.EnvironmentName}.json", optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables();
                }

                Configuration = builder.Build();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var connection = @"Server=103.91.207.110;Database=LNA;user id=sa;password=P@ssw0rd2019;Trusted_Connection=False;";
            services.AddDbContext<LNAContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
