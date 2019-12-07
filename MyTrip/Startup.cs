using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyTrip.Repositories;


namespace MyTrip
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Added MVC services to empty project
            services.AddMvc();

            //Dependency Injection
            services.AddTransient<ITripRepository, TripRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }           
         

            app.UseDefaultFiles();
            app.UseStaticFiles();

            //deleted Hello World code and added this code
            app.UseMvcWithDefaultRoute();

          

            //Changed the routing of default locations so it will run with UserHomeController and UserHomeScreen view
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=UserHome}/{action=UserLogInScreen}/{id?}");
            });


        }
    }
}
