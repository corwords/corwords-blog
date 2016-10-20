using Corwords.Data;
using Corwords.Data.Blog;
using System.Linq;

namespace Corwords.Core.Content.Blog
{
    public class BlogManager
    {
        private ICorwordsContext _context;

        public BlogManager(ICorwordsContext context)
        {
            _context = context;
        }

        public TransactionStatus CreateBlog(string name, string url)
        {
            var status = new TransactionStatus();

            var sameBlogName = _context.Blogs.Any(a => a.Name == name);
            if (sameBlogName)
                status.AddFailMessage("A blog with this name already exists.");

            var sameBlogUrl = _context.Blogs.Any(a => a.Url == url);
            if (sameBlogUrl)
                status.AddFailMessage("A blog with this URL already exists.");

            if (status.Success)
            {
                var blog = new IndividualBlog() { Name = name, Url = url };
                _context.Blogs.Add(blog);
                _context.SaveChanges();
            }

            return status;
        }


    }
}