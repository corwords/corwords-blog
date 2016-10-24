using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface IPostTag<TBlog, TBlogPost, TPostTag>
        where TBlog : IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : IPostTag<TBlog, TBlogPost, TPostTag>
    {
        int PostTagId { get; set; }

        int PostId { get; set; }
        IBlogPost<TBlog, TBlogPost, TPostTag> Post { get; set; }

        int TagId { get; set; }
        ITag<TBlog, TBlogPost, TPostTag> Tag { get; set; }
    }
}
