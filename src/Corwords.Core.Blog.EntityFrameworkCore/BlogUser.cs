using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class BlogUser : IBlogUser
    {
        public virtual string Id { get; set; }
        public virtual string Username { get; set; }
        public virtual SecureString Password { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string EmailAddress { get; set; }
    }
}
