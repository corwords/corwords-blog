using Corwords.Core.MetaWeblog;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WilderMinds.MetaWeblog;

namespace Corwords
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Setup options with DI
            services.AddOptions();

            // Add authentication services
            services.AddAuthentication(options => options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme);

            // Add blog import service
            services.AddMetaWeblog<SqlMetaWeblogService>();

            // Add MVC
            services.AddMvcCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            // Load configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath + "\\config")
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
            app.UseMetaWeblog("/livewriter");

            // Add environment variables
            builder.AddEnvironmentVariables();
            builder.Build();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
