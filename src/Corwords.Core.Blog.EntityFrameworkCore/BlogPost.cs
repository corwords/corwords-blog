using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class BlogPost : IBlogPost<Blog, BlogPost, PostTag>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual string Slug { get; set; }
        public virtual string Author { get; set; }
        public virtual string AuthorUsername { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateUpdate { get; set; }

        public virtual int BlogId { get; set; }
        public virtual IBlog<Blog, BlogPost, PostTag> Blog { get; set; }
        public virtual IList<PostTag> PostTags { get; set; }
    }
}