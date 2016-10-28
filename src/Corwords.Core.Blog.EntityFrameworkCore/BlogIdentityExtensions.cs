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
        public static BlogBuilder AddIdentity<TUserManager, TRoleManager>(this BlogBuilder builder)
            where TUserManager : class
            where TRoleManager : class
        {
            builder.Services.TryAdd(GetDefaultServices(builder.BlogUserType, typeof(TUserManager), typeof(TRoleManager)));
            return builder;
        }

        private static IServiceCollection GetDefaultServices(Type blogUserType, Type userManagerType, Type roleManagerType)
        {
            //var blogUserServiceType = typeof(BlogUserService).MakeGenericType(blogUserType, contextType);
            var services = new ServiceCollection();
            //services.AddScoped(typeof(IBlogUserService).MakeGenericType(blogUserType), blogUserServiceType);
            return services;
        }
    }
}
