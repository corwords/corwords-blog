using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface IBlogUserService<TUserManager, TRoleManager>
        where TUserManager : class
        where TRoleManager : class
    {
    }
}
