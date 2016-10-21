using Microsoft.EntityFrameworkCore;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class BlogStore<TBlog, TContext>
        where TBlog : Blog<string>
        where TContext : DbContext
    {
        public BlogStore(TContext context) { }
    }
}