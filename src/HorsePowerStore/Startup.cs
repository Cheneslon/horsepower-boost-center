using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.FileProviders;
using System.IO;
using HorsePowerStore.Data;
using HorsePowerStore.Models;
using HorsePowerStore.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HorsePowerStore
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc(options => // added for external login provider (DG)
            {
                options.Filters.Add(new RequireHttpsAttribute());
            });

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            services.AddScoped<CarsService>();
            services.AddScoped<CarModsService>();
            services.AddScoped<ProductsService>();
            services.AddScoped<CarInstancesService>();

            services.AddMvc().AddJsonOptions(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            // add security policies
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy => policy.RequireClaim("IsAdmin"));
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "bower_components")),
                RequestPath = "/bower_components"
            });

            app.UseIdentity();

            // Add external authentication middleware below. To configure them please see http://go.microsoft.com/fwlink/?LinkID=532715
            app.UseFacebookAuthentication(new FacebookOptions()// added for Facebook login (DG)
            {
                AppId = "522598474600542",
                AppSecret = "ba947e6b0e6b0007d3eaf7772b81ca3f"
            });
            app.UseTwitterAuthentication(new TwitterOptions
            {
                ConsumerKey = "iCtnTS3isNjMqjNGmXqncWgRR",
                ConsumerSecret = "MlSPOV0yyJwF70Ky8N2NWhTBBpwhqbZhjMZ6srlX6io4KPwjfc"
            });
            app.UseGoogleAuthentication(new GoogleOptions()
            {
                ClientId = "1075063684469-6da3i6js1fknrqiaach0lik4amibssqq.apps.googleusercontent.com",
                ClientSecret = "IV1mLdmVx3iJFFOaSMp22Syx"
            });
            app.UseMicrosoftAccountAuthentication(new MicrosoftAccountOptions()
            {
                ClientId = "acb706be-d51c-4fde-8070-940e256b87ee",
                ClientSecret = "NOEmX1AkF8LafLHGQ9VKZTW"
            });
            


            /*  TODO: Set up Twitter authentication
             *  
                app.UseTwitterAuthentication(new TwitterOptions()
                {
                    AppId = "",
                    AppSecret = ""
                });
            */

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{*path}",
                    defaults: new { controller = "Home", action = "Index" }
                );
            });

           // initialize sample data
           SampleData.Initialize(app.ApplicationServices).Wait();
           
        }
    }
}
