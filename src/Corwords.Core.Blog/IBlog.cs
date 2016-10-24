using System.Collections.Generic;

namespace Corwords.Core.Blog
{
    public interface IBlog<TBlog, TBlogPost, TPostTag>
        where TBlog : class, IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : class, IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : class, IPostTag<TBlog, TBlogPost, TPostTag>
    {
        int Id { get; set; }
        string Name { get; set; }
        IList<TBlogPost> Posts { get; set; }
        string Url { get; set; }
    }
}