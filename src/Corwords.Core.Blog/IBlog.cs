using System.Collections.Generic;

namespace Corwords.Core.Blog
{
    public interface IBlog
    {
        int Id { get; set; }
        string Name { get; set; }
        IList<IBlogPost> Posts { get; set; }
        string Url { get; set; }
    }
}