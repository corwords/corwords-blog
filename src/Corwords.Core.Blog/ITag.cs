using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface ITag<TBlog, TBlogPost, TPostTag>
        where TBlog : IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : IPostTag<TBlog, TBlogPost, TPostTag>
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime DateCreated { get; set; }
        IList<TPostTag> PostTags { get; set; }
    }
}
