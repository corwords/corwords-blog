using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface IPostTag<TBlog, TBlogPost, TPostTag>
        where TBlog : class, IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : class, IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : class, IPostTag<TBlog, TBlogPost, TPostTag>
    {
        int PostTagId { get; set; }

        int PostId { get; set; }
        IBlogPost<TBlog, TBlogPost, TPostTag> Post { get; set; }

        int TagId { get; set; }
        ITag<TBlog, TBlogPost, TPostTag> Tag { get; set; }
    }
}
