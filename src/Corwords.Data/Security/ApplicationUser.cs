using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Corwords.Data.Security
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}