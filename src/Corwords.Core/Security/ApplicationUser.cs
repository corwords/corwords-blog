using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Corwords.Core.Security
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}