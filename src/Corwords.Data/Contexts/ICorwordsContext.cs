using Corwords.Data.Blog;
using Microsoft.EntityFrameworkCore;

namespace Corwords.Data
{
    public interface ICorwordsContext
    {
        DbSet<IndividualBlog> Blogs { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Enclosure> Enclosures { get; set; }
        DbSet<MediaObjectInfo> MediaObjectInfos { get; set; }
        DbSet<MediaObject> MediaObjects { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Source> Sources { get; set; }
    }
}