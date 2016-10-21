using System.Collections.Generic;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public interface IBlog
    {
        int Id { get; set; }
        string Name { get; set; }
        List<IBlogPost> Posts { get; set; }
        string Url { get; set; }
    }
}