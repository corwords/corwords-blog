using System.Collections.Generic;

namespace Corwords.Core.Blog
{
    public interface IBlog<TPostTag>
        where TPostTag : IPostTag<TPostTag>
    {
        int Id { get; set; }
        string Name { get; set; }
        IList<TPostTag> Posts { get; set; }
        string Url { get; set; }
    }
}