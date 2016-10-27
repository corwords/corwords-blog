using System;
using Microsoft.Extensions.DependencyInjection;

namespace Corwords.Core.Blog
{
    public class BlogBuilder
    {
        public Type BlogType { get; private set; }
        public Type BlogUserType { get; private set; }
        public IServiceCollection Services { get; private set; }

        public BlogBuilder(Type blog, Type blogUser, IServiceCollection services)
        {
            BlogType = blog;
            BlogUserType = blogUser;
            Services = services;
        }
    }
}
