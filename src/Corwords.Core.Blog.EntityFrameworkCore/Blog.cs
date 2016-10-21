using System;
using System.Collections.Generic;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class Blog : Blog<string>
    {
        public Blog()
        {
            Id = Guid.NewGuid().ToString();
        }

        public Blog(string name) : this()
        {
            Name = name;
        }
    }

    public class Blog<TKey> : Blog<TKey, BlogPost<TKey>, BlogTag<TKey>, BlogMedia<TKey>>
        where TKey : IEquatable<TKey>
    { }

    public class Blog<TKey, TBlogPost, TBlogTag, TBlogMedia> where TKey : IEquatable<TKey>
    {
        public Blog() { }

        public Blog(string name) : this()
        {
            Name = name;
        }

        // public int BlogId { get; set; }
        public virtual TKey Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual ICollection<TBlogPost> Posts { get; } = new List<TBlogPost>();
    }
}