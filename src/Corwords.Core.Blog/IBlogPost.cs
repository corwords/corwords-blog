using System;
using System.Collections.Generic;

namespace Corwords.Core.Blog
{
    public interface IBlogPost<TBlog, TBlogPost, TPostTag>
        where TBlog : class, IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : class, IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : class, IPostTag<TBlog, TBlogPost, TPostTag>
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
        IBlog<TBlog, TBlogPost, TPostTag> Blog { get; set; }
        IList<TPostTag> PostTags { get; set; }
    }
}
