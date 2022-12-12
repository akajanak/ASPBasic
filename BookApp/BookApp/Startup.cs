using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookApp
{
    public class Startup
    {
            public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<BookStoreContext>(options => options.UseSqlServer("Server=localhost;DataBase=BookStore;Integrated Security=True"));
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
        }
        public void configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                /* endpoints.MapControllerRoute(name: "Default",
                     pattern: "{controller=Home}/{action=Index}/{id?}");
                */
            });
            }
    }

    
}
