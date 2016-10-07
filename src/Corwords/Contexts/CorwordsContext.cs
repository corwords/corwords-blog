using Microsoft.EntityFrameworkCore;

namespace Corwords.Data
{
    public class CorwordsContext : DbContext
    {
        public CorwordsContext(DbContextOptions<SecurityContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        // Blog Models
        public DbSet<Blog.IndividualBlog> Blogs { get; set; }
        public DbSet<Blog.Post> Posts { get; set; }
        public DbSet<Blog.Category> Categories { get; set; }
        public DbSet<Blog.MediaObject> MediaObjects { get; set; }
        public DbSet<Blog.MediaObjectInfo> MediaObjectInfos { get; set; }
        public DbSet<Blog.Enclosure> Enclosures { get; set; }
        public DbSet<Blog.Source> Sources { get; set; }
    }
}
