using Microsoft.Extensions.Logging;

namespace Corwords.Core.Blog
{
    public class MetaWeblogService<TPostTag> : XmlRpcService
        where TPostTag : class, IPostTag<TPostTag>
    {
        private IBlogService<TPostTag> _service;
        private ILogger<MetaWeblogService<TPostTag>> _logger;

        public MetaWeblogService(IBlogService<TPostTag> service, ILogger<MetaWeblogService<TPostTag>> logger) : base(logger)
        {
            _service = service;
            _logger = logger;
        }
    }
}