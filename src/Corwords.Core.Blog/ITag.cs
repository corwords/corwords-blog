using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface ITag<TBlog, TBlogPost, TPostTag>
        where TBlog : class, IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : class, IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : class, IPostTag<TBlog, TBlogPost, TPostTag>
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime DateCreated { get; set; }
        IList<TPostTag> PostTags { get; set; }
    }
}
