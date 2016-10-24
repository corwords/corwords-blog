using System;
using System.Collections.Generic;

namespace Corwords.Core.Blog
{
    public interface IBlogPost<TPostTag>
        where TPostTag : IPostTag<TPostTag>
    {
        int Id { get; set; }
        string Title { get; set; }
        string Content { get; set; }
        string Slug { get; set; }
        string Author { get; set; }
        string AuthorUsername { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateUpdate { get; set; }

        int BlogId { get; set; }
        IBlog<TPostTag> Blog { get; set; }
        IList<TPostTag> PostTags { get; set; }
    }
}
