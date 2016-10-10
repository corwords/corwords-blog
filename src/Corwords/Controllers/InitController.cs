﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Corwords.Core.Config;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Corwords.Controllers
{
    public class InitController : Controller
    {
        private readonly IOptions<FirstRunOptions> _firstRunOptions;

        public InitController(IOptions<FirstRunOptions> firstRunOptions)
        {
            _firstRunOptions = firstRunOptions;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            if (_firstRunOptions.Value.Enabled)
                return View();

            return new NotFoundResult();
        }
    }
}
