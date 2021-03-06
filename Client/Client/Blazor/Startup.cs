
using System;
using Blazor.Authentication;
using Blazor.Data;
using Blazored.Modal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Model;
using Syncfusion.Blazor;

namespace Blazor
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
            services.AddBlazoredModal();
            services.AddSyncfusionBlazor();

           // services.AddBlazoredLocalStorage(config =>config.JsonSerializerOptions.WriteIndented = true);
            
            services.AddScoped<IServiceUser, ServiceUser>();
            
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddHttpClient<IServiceUser,ServiceUser>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:8080/");
            });
            services.AddHttpClient<ITaskServices,TaskServices>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:8080/");
            });
            services.AddHttpClient<IShiftService,ShiftService>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:8080/");
            });
            
            
            services.AddAuthorization(options =>
            {
                options.AddPolicy("MustBeAdmin", a =>
                {
                    a.RequireAuthenticatedUser().RequireClaim("Role", Role.admin.ToString());
                });
                options.AddPolicy("MustBePartTimeEmp", a =>
                {
                    a.RequireAuthenticatedUser().RequireClaim("Role", Role.partTimeEmployee.ToString());
                });
                options.AddPolicy("MustBeFullTimeEmp", a =>
                {
                    a.RequireAuthenticatedUser().RequireClaim("Role", Role.fullTimeEmployee.ToString());
                });
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(
                "NTQ1OTk4QDMxMzkyZTMzMmUzME9Oa3VPdFVZN2JKTW45cG5VRXBMOGh4YjdKeGptbjlWcUM1TkljY29NWVE9");
            
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