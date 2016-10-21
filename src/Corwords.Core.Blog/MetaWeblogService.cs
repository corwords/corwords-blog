using Microsoft.Extensions.Logging;

namespace Corwords.Core.Blog
{
    public class MetaWeblogService : XmlRpcService
    {
        private IBlogService _service;
        private ILogger<MetaWeblogService> _logger;

        public MetaWeblogService(IBlogService service, ILogger<MetaWeblogService> logger) : base(logger)
        {
            _service = service;
            _logger = logger;
        }
    }
}