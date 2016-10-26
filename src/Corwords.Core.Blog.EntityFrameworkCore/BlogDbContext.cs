using Microsoft.EntityFrameworkCore;

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
            builder.Entity<TBlog>().ToTable("Corwords_Blogs");
            builder.Entity<TBlogPost>().ToTable("Corwords_BlogPosts");
            builder.Entity<TTag>().ToTable("Corwords_BlogTags");
            builder.Entity<TMediaObject>().ToTable("Corwords_BlogMediaObjects");
            builder.Entity<TMediaObjectInfo>().ToTable("Corwords_BlogMediaObjectInfos");
            builder.Entity<TEnclosure>().ToTable("Corwords_BlogEnclosures");
            builder.Entity<TSource>().ToTable("Corwords_BlogSources");

            builder.Entity<PostTag>(b =>
            {
                b.ToTable("Corwords_BlogPostTags");
                b.HasOne(pt => (BlogPost)pt.Post).WithMany(bp => bp.PostTags).HasForeignKey(pc => pc.PostId).IsRequired();
                b.HasOne(pt => (Tag)pt.Tag).WithMany(t => t.PostTags).HasForeignKey(pc => pc.TagId).IsRequired();
            });

            base.OnModelCreating(builder);
        }
    }
}