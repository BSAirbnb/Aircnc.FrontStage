using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Services;
using Aircnc.FrontStage.Services.RoomOwner;
using Aircnc.FrontStage.Services.Guest;
using Aircnc_0321.Repositories;
using Microsoft.AspNetCore.Builder;
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
using Aircnc.FrontStage.Services.Transaction;

namespace Aircnc.FrontStage
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
            //¸ê®Æ®wª`¤J
            services.AddDbContext<AircncContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AircncContext"));

            });
            services.AddTransient<DBRepository, DBRepository>();
            services.AddTransient<HostListService, HostListService>();
            services.AddTransient<HostReservationService, HostReservationService>();
            services.AddTransient<HostHomePageService, HostHomePageService>();
            services.AddTransient<OrderService, OrderService>();
            services.AddTransient<RoomDetailService, RoomDetailService>();
            services.AddTransient<NavSearchService, NavSearchService>();
            services.AddTransient<FutureTransactionService, FutureTransactionService>();

            services.AddTransient<SearchRoomService, SearchRoomService>();
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
