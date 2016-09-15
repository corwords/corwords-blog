using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Corwords.Core.Config;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Corwords.Controllers
{
    public class InitController : Controller
    {
        private readonly FirstRunOptions _firstRunOptions;

        public InitController(IOptions<FirstRunOptions> optionsAccessor)
        {
            _firstRunOptions = optionsAccessor.Value;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            if (_firstRunOptions.Enabled)
                return View();

            return new NotFoundResult();
        }
    }
}
