using System;
using System.Collections.Generic;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class BlogPost<TKey> where TKey : IEquatable<TKey>
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual string Slug { get; set; }
        public virtual string Author { get; set; }
        public virtual string AuthorUsername { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateUpdate { get; set; }

        public virtual TKey BlogId { get; set; }
        public virtual ICollection<BlogTag<TKey>> Tags { get; set; }
    }
}