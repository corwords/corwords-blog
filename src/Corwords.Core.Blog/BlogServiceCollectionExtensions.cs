using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Corwords.Core.Blog
{
    public static class BlogServiceCollectionExtensions
    {
        public static IApplicationBuilder UseMetaWeblog<TBlog, TBlogPost, TPostTag>(this IApplicationBuilder builder, string path)
            where TBlog : class, IBlog<TBlog, TBlogPost, TPostTag>
            where TBlogPost : class, IBlogPost<TBlog, TBlogPost, TPostTag>
            where TPostTag : class, IPostTag<TBlog, TBlogPost, TPostTag>
        {
            return builder.UseMiddleware<MetaWeblogMiddleware<TBlog, TBlogPost, TPostTag>>(path);
        }

        public static BlogBuilder AddBlogging<TBlogService, TBlogUserService, TBlog, TBlogPost, TPostTag>(this IServiceCollection services)
            where TBlogService : class, IBlogService<TBlog, TBlogPost, TPostTag>
            where TBlogUserService : class, IBlogUserService
            where TBlog : class, IBlog<TBlog, TBlogPost, TPostTag>
            where TBlogPost : class, IBlogPost<TBlog, TBlogPost, TPostTag>
            where TPostTag : class, IPostTag<TBlog, TBlogPost, TPostTag>
        {
            services.AddScoped<IBlogService<TBlog, TBlogPost, TPostTag>, TBlogService>();
            services.AddScoped<IBlogUserService>();
            services.AddScoped<MetaWeblogService<TBlog, TBlogPost, TPostTag>>();
            return new BlogBuilder(typeof(TBlogService), typeof(TBlogUserService), services);
        }
    }
}