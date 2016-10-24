using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Corwords.Core.Blog
{
    public static class BlogServiceCollectionExtensions
    {
        public static IApplicationBuilder UseMetaWeblog<TPostTag>(this IApplicationBuilder builder, string path)
            where TPostTag : class, IPostTag<TPostTag>
        {
            return builder.UseMiddleware<MetaWeblogMiddleware<TPostTag>>(path);
        }

        public static BlogBuilder AddBlogging<TBlogService, TPostTag>(this IServiceCollection services)
            where TBlogService : class, IBlogService<TPostTag>
            where TPostTag : class, IPostTag<TPostTag>
        {
            services.AddScoped<IBlogService<TPostTag>, TBlogService>();
            services.AddScoped<MetaWeblogService<TPostTag>>();
            return new BlogBuilder(typeof(TBlogService), services);
        }
    }
}