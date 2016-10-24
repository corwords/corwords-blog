using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class PostTag : IPostTag<Blog, BlogPost, PostTag>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int PostTagId { get; set; }

        public virtual int PostId { get; set; }
        public virtual IBlogPost<Blog, BlogPost, PostTag> Post { get; set; }

        public virtual int TagId { get; set; }
        public virtual ITag<Blog, BlogPost, PostTag> Tag { get; set; }
    }
}
