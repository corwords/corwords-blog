using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class BlogUserService : IBlogUserService<Microsoft.AspNetCore.Identity.UserManager, Microsoft.AspNetCore.Identity.RoleManager>
    {
    }
}
