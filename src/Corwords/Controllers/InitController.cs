using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Corwords.Core.Config;
using Corwords.Core.Security;
using Microsoft.AspNetCore.Identity;
using Corwords.Data.Security;
using System.Threading.Tasks;
using Corwords.Data;
using Corwords.Core.Content.Blog;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Corwords.Controllers
{
    public class InitController : Controller
    {
        private FirstRunOptions _firstRunOptions;
        private FeatureOptions _featureOptions;
        private readonly CorwordsContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public InitController(CorwordsContext context, UserManager<ApplicationUser> userManager, IOptions<FirstRunOptions> firstRunOptions, IOptions<FeatureOptions> featureOptions)
        {
            _context = context;
            _userManager = userManager;
            _firstRunOptions = firstRunOptions.Value;
            _featureOptions = featureOptions.Value;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            if (_firstRunOptions.FirstRunEnabled)
            {
                var securitySetup = new SecuritySetup(_userManager);
                var securitySetupStatus = await securitySetup.Initialize(_firstRunOptions.AdminEmailAddress, _firstRunOptions.AdminUsername, _firstRunOptions.AdminPassword);

                if (securitySetupStatus.Success)
                    return View();
            }

            if (_featureOptions.Blogging)
            {
                var blogManager = new BlogManager(_context);
                var blogStatus = blogManager.CreateBlog("blog", "/blog");

                if (blogStatus.Success)
                    return View();
            }

            return new NotFoundResult();
        }
    }
}
