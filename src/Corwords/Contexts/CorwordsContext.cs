using Corwords.Core.Blog.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Corwords.Data
{
    public class CorwordsContext : BlogDbContext
    {
        public CorwordsContext(DbContextOptions<CorwordsContext> options) : base(options) { }
    }
}