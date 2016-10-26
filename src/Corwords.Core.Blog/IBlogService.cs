using System;

namespace Corwords.Core.Blog
{
    public interface IBlogService<TBlog, TBlogPost, TPostTag> : IMetaWeblog<TBlog, TBlogPost, TPostTag>, IDisposable
        where TBlog : class, IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : class, IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : class, IPostTag<TBlog, TBlogPost, TPostTag>
    {

    }
}