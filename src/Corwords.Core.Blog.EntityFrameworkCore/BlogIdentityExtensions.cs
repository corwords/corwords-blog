using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public static class BlogIdentityExtensions
    {
        public static BlogBuilder AddIdentity<TContext, TUser, TRole>(this BlogBuilder builder)
            where TUser : class
            where TRole : class
            where TContext : DbContext
        {
            builder.Services.TryAdd(GetDefaultServices(builder.BlogUserType, typeof(TContext), typeof(TUser), typeof(TRole)));
            return builder;
        }

        private static IServiceCollection GetDefaultServices(Type blogUserType, Type contextType, Type userType, Type roleType)
        {
            var blogUserServiceType = typeof(BlogUserService).MakeGenericType(blogUserType, contextType);
            var services = new ServiceCollection();
            services.AddScoped(typeof(IBlogUserService).MakeGenericType(blogUserType), blogUserServiceType);
            return services;
        }
    }
}
