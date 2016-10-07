using Corwords.Core.MetaWeblog;
using Corwords.Data;
using Corwords.Data.Security;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WilderMinds.MetaWeblog;

namespace Corwords
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            // Load configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath + "\\config")
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Setup options with DI
            services.AddOptions();
            //services.Configure<FirstRunOptions>(Configuration.GetSection("FirstRunOptions") as FirstRunOptions);

            // Add the database context
            services.AddDbContext<SecurityContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Add authentication services
            services.AddIdentity<ApplicationUser, IdentityRole > ()
                .AddEntityFrameworkStores<SecurityContext>()
                .AddDefaultTokenProviders();
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
            app.UseMetaWeblog("/livewriter");

            // Add MVC
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
