﻿using Corwords.Core.Blog;
using Corwords.Core.Blog.EntityFrameworkCore;
using Corwords.Core.Config;
using Corwords.Core.MVC;
using Corwords.Core.Security;
using Corwords.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Corwords
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            // Load configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("config\\appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"config\\appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets();
            }

            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Setup options with DI
            //services.AddOptions();
            services.Configure<FirstRunOptions>(Configuration.GetSection("FirstRunOptions"));
            services.Configure<FeatureOptions>(Configuration.GetSection("FeatureOptions"));

            // Add the database context
            services.AddDbContext<CorwordsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<SecurityContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Add authentication services
            services.AddIdentity<ApplicationUser, IdentityRole> ()
                .AddEntityFrameworkStores<SecurityContext>()
                .AddDefaultTokenProviders();
            services.AddAuthentication(options => options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme);

            // Add blog services
            services.AddBlogging<BlogService, BlogUserService, Blog, BlogPost, PostTag>()
                .AddEntityFrameworkStores<CorwordsContext>()
                .AddIdentity<UserManager<ApplicationUser>, RoleManager<IdentityRole>>();
                //.AddIdentity<SecurityContext, ApplicationUser, IdentityRole>();

            // Add MVC
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            // In development, Add Exception Page
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Allow static files
            app.UseStaticFiles();

            // Add Cookie Middleware
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AutomaticAuthenticate = true,
                AutomaticChallenge = true,
                LoginPath = new PathString("/login"),
                LogoutPath = new PathString("/logout")
            });

            app.UseIdentity();

            // TODO: Add UseOAuthAuthentication middleware for connecting to 3rd parties (i.e. Facebook, Twitter, LinkedIn, Microsoft, GitHub)

            // Add MetaWeblog Middleware
            app.UseMetaWeblog<Blog, BlogPost, PostTag>("/metaweblog");

            // Add MVC
            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            // Check if FirstRunEnabled == true
            routeBuilder.MapRoute("firstrun", "{*firstrun}", defaults: new { controller = "Init", action = "Index" }, constraints: new { firstrun = new FirstRunContraint() });

            // Add default route
            routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
