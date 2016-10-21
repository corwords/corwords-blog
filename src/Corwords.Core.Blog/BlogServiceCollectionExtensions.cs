using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Corwords.Core.Blog
{
    public static class BlogServiceCollectionExtensions
    {
        public static IApplicationBuilder UseMetaWeblog(this IApplicationBuilder builder, string path)
        {
            return builder.UseMiddleware<MetaWeblogMiddleware>(path);
        }

        public static BlogBuilder AddBlogging<TBlogService>(this IServiceCollection services)
            where TBlogService : class, IBlogService
        {
            services.AddScoped<IBlogService, TBlogService>();
            services.AddScoped<MetaWeblogService>();
            return new BlogBuilder(typeof(TBlogService), services);
        }
    }
}