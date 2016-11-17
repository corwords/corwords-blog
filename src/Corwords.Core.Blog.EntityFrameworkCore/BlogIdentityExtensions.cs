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
            builder.Services.TryAdd(GetDefaultServices<TUserManager, TRoleManager>(builder.BlogUserType));
            return builder;
        }

        private static IServiceCollection GetDefaultServices<TUserManager, TRoleManager>(Type blogUserType)
            where TUserManager : class
            where TRoleManager : class
        {
            var userManagerType = typeof(TUserManager);
            var roleManagerType = typeof(TRoleManager);
            var blogUserManagerType = typeof(BlogUserService).MakeGenericType(blogUserType, userManagerType);
            var services = new ServiceCollection();
            //services.AddScoped(typeof(IBlogUserService).MakeGenericType(blogUserType), blogUserManagerType);
            return services;
        }
    }
}
