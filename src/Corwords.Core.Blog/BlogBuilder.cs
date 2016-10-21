using System;
using Microsoft.Extensions.DependencyInjection;

namespace Corwords.Core.Blog
{
    public class BlogBuilder
    {
        public Type BlogType { get; private set; }
        public IServiceCollection Services { get; private set; }

        public BlogBuilder(Type blog, IServiceCollection services)
        {
            BlogType = blog;
            Services = services;
        }
    }
}
