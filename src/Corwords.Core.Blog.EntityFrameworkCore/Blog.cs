using System;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class Blog : Blog<string>
    {
        public Blog()
        {
            Id = Guid.NewGuid().ToString();
        }

        public Blog(string blogName) : this()
        {
            BlogName = blogName;
        }
    }

    public class Blog<TKey> : Blog<TKey, BlogPost<TKey>, BlogTag<TKey>, BlogMedia<TKey>>
        where TKey : IEquatable<TKey>
    { }

    public class Blog<TKey, TBlogPost, TBlogTag, TBlogMedia> where TKey : IEquatable<TKey>
    {
        public Blog() { }

        public Blog(string blogName) : this()
        {
            BlogName = blogName;
        }

        public virtual TKey Id { get; set; }
        public virtual string BlogName { get; set; }
    }
}