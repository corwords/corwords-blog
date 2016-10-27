using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface IUserInfo
    {
        string Id { get; set; }
        string Username { get; set; }
        SecureString Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
    }
}
