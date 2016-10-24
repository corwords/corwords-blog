using System.Collections.Generic;

namespace Corwords.Core.Blog
{
    public interface IBlog<TBlog, TBlogPost, TPostTag>
        where TBlog : IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : IPostTag<TBlog, TBlogPost, TPostTag>
    {
        int Id { get; set; }
        string Name { get; set; }
        IList<TBlogPost> Posts { get; set; }
        string Url { get; set; }
    }
}