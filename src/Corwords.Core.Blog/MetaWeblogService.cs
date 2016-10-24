using Microsoft.Extensions.Logging;

namespace Corwords.Core.Blog
{
    public class MetaWeblogService<TBlog, TBlogPost, TPostTag> : XmlRpcService
        where TBlog : class, IBlog<TBlog, TBlogPost, TPostTag>
        where TBlogPost : class, IBlogPost<TBlog, TBlogPost, TPostTag>
        where TPostTag : class, IPostTag<TBlog, TBlogPost, TPostTag>
    {
        private IBlogService<TBlog, TBlogPost, TPostTag> _service;
        private ILogger<MetaWeblogService<TBlog, TBlogPost, TPostTag>> _logger;

        public MetaWeblogService(IBlogService<TBlog, TBlogPost, TPostTag> service, ILogger<MetaWeblogService<TBlog, TBlogPost, TPostTag>> logger) : base(logger)
        {
            _service = service;
            _logger = logger;
        }
    }
}