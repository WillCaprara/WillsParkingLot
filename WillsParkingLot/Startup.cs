using Blazored.Toast;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillsParkingLot.Data;
using WillsParkingLot.Data.Repositories;
using WillsParkingLot.Data.Repositories.Implementation;
using WillsParkingLot.DbContexts;
using WillsParkingLot.Helpers;
using WillsParkingLot.Services;

namespace WillsParkingLot
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddDbContext<WillsParkingLotContext>(x => x.UseSqlServer(Configuration.GetConnectionString("WillsParkingLotConnection")));

            //Services
            services.AddTransient<ParkingService>();
            services.AddBlazoredToast();

            //Repositories
            services.AddTransient<IParkingRepository, ParkingRepository>();
            services.AddTransient<IRateYearDayRepository, RateYearDayRepository>();
            services.AddTransient<IParkingFeeRepository, ParkingFeeRepository>();

            //Helpers
            services.AddScoped<IParkingFeeHelper, ParkingFeeHelper>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
