using Corwords.Data.Security;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Security
{
    public class SecuritySetup
    {
        private UserManager<ApplicationUser> _userManager;

        public SecuritySetup(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<TransactionStatus> Initialize(string email, string username, string password)
        {
            var status = new TransactionStatus();

            var user = new ApplicationUser { UserName = username };
            var result = await _userManager.CreateAsync(user, password);

            if (!result.Succeeded)
                status.AddFailMessage(result.Errors.First().Description, false);

            return status;
        }
    }
}
