using Corwords.Data.Security;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Security
{
    public class Init
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public void AddAdminUser()
        {
            var user = new ApplicationUser { };

            _userManager.CreateAsync(new ApplicationUser() { });
        }
    }
}
