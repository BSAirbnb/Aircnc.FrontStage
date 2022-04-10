using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Services;
using Aircnc.FrontStage.Services.RoomOwner;
using Aircnc.FrontStage.Services.Guest;
using AircncFrontStage.Repositories;
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
using Aircnc.FrontStage.Services.Account.Interface;
using Aircnc.FrontStage.Services.Account;
using Aircnc.FrontStage.Services.Common;
using Microsoft.AspNetCore.Authentication.Cookies;

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
            //資料庫注入
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
            services.AddTransient<TransactionService, TransactionService>();
            services.AddTransient<IAccountService, AccountService>();

            services.AddTransient<SearchRoomService, SearchRoomService>();
            services.AddTransient<SearchControllerService, SearchControllerService>();
            services.AddTransient<MailService, MailService>();
            services.AddTransient<CalendarService, CalendarService>();
            services.AddTransient<CreateRoomService, CreateRoomService>();

            services.AddHttpContextAccessor();
            services.AddTransient<HostRoomEditService, HostRoomEditService>();

            //設定驗證方式
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
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
            //驗證
            app.UseAuthentication();
            app.UseAuthorization();
            //跨域
            app.UseCors();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
