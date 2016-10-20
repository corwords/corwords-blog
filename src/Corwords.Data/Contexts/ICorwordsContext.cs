using Corwords.Data.Blog;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

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

        #region DbContext Methods
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
        #endregion
    }
}