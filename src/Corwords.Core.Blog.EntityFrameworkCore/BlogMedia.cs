using System;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class BlogMedia<TKey> where TKey : IEquatable<TKey>
    {
        public virtual int Id { get; set; }
        public virtual TKey BlogId { get; set; }
    }
}