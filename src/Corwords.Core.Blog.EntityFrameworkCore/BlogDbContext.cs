using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public abstract class BlogDbContext : BlogDbContext<Blog, PostTag, Tag, MediaObject, MediaObjectInfo, Enclosure, Source>
    {
        protected BlogDbContext() { }

        public BlogDbContext(DbContextOptions options) : base(options) { }
    }

    public abstract class BlogDbContext<TBlog, TBlogPost, TTag, TMediaObject, TMediaObjectInfo, TEnclosure, TSource> : DbContext
        where TBlog : Blog
        where TBlogPost : PostTag
        where TTag : Tag
        where TMediaObject : MediaObject
        where TMediaObjectInfo : MediaObjectInfo
        where TEnclosure : Enclosure
        where TSource : Source
    {
        protected BlogDbContext() { }
        public BlogDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TBlog> Blogs { get; set; }
        public DbSet<TBlogPost> Posts { get; set; }
        public DbSet<TTag> Categories { get; set; }
        public DbSet<TMediaObject> MediaObjects { get; set; }
        public DbSet<TMediaObjectInfo> MediaObjectInfos { get; set; }
        public DbSet<TEnclosure> Enclosures { get; set; }
        public DbSet<TSource> Sources { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PostTag>()
                .HasOne(pt => (BlogPost)pt.Post)
                .WithMany(bp => (List<PostTag>)bp.PostTags)
                .HasForeignKey(pc => pc.PostId);

            builder.Entity<PostTag>()
                .HasOne(pt => (Tag)pt.Tag)
                .WithMany(t => (List<PostTag>)t.PostTags)
                .HasForeignKey(pc => pc.TagId);

            base.OnModelCreating(builder);
        }
    }
}