using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Corwords.Core.Config;
using Corwords.Core.Security;
using Microsoft.AspNetCore.Identity;
using Corwords.Data.Security;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Corwords.Controllers
{
    public class InitController : Controller
    {
        private FirstRunOptions _firstRunOptions;
        private readonly UserManager<ApplicationUser> _userManager;

        public InitController(UserManager<ApplicationUser> userManager, IOptions<FirstRunOptions> firstRunOptions)
        {
            _userManager = userManager;
            _firstRunOptions = firstRunOptions.Value;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            if (_firstRunOptions.FirstRunEnabled)
            {
                var securitySetup = new SecuritySetup(_userManager);
                var success = await securitySetup.Initialize(_firstRunOptions.AdminEmailAddress, _firstRunOptions.AdminUsername, _firstRunOptions.AdminPassword);

                if (success)
                    return View();
            }

            return new NotFoundResult();
        }
    }
}
