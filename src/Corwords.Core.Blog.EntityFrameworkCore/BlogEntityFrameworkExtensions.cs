using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public static class BlogEntityFrameworkExtensions
    {
        public static BlogBuilder AddEntityFrameworkStores<TContext>(this BlogBuilder builder)
            where TContext : DbContext
        {
            builder.Services.TryAdd(GetDefaultServices(builder.BlogType, typeof(TContext)));
            return builder;
        }

        private static IServiceCollection GetDefaultServices(Type blogType, Type contextType)
        {
            var blogStoreType = typeof(BlogStore<,>).MakeGenericType(blogType, contextType);
            var services = new ServiceCollection();
            services.AddScoped(typeof(IBlogStore<>).MakeGenericType(blogType), blogStoreType);
            return services;
        }
    }
}