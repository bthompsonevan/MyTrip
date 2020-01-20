using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyTrip.Repositories;
using MyTrip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace MyTrip
{
    public class Startup
    {
        private IHostingEnvironment environment;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            environment = env;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Added MVC services to empty project
            services.AddMvc();

            

            //Dependency Injection
            services.AddTransient<ITripRepository, TripRepository>();

            if (environment.IsDevelopment())
            {
                //AppDbSuff
                services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                   Configuration["ConnectionString:LocalDbString"]));
            } else if (environment.IsProduction())
            {
                services.AddDbContext<AppDbContext>(options => options.UseMySql(Configuration["ConnectionString:MySqlConnection"]));
            }

            //Adding Identity to project
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>()
                       .AddDefaultTokenProviders();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, AppDbContext context)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }           
         

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseStatusCodePages();

            //deleted Hello World code and added this code
            app.UseMvcWithDefaultRoute();

            //adding authentication to project from identity
            app.UseAuthentication();

            // Create or update the database and apply migrations.
            context.Database.Migrate();



            //Changed the routing of default locations so it will run with UserHomeController and UserHomeScreen view
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=UserHome}/{action=UserLogInScreen}/{id?}");
            });


        }
    }
}
