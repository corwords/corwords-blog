using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Corwords.Core.Config;
using Corwords.Core.Security;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Corwords.Controllers
{
    public class InitController : Controller
    {
        private FirstRunOptions _firstRunOptions;

        public InitController(IOptions<FirstRunOptions> firstRunOptions)
        {
            _firstRunOptions = firstRunOptions.Value;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            if (_firstRunOptions.FirstRunEnabled)
            {
                var success = SecuritySetup.Initialize(_firstRunOptions.AdminEmailAddress, _firstRunOptions.AdminUsername, _firstRunOptions.AdminPassword);

                if (success)
                    return View();
            }

            return new NotFoundResult();
        }
    }
}
