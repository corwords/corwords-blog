using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface IPostTag
    {
        int PostCategoryId { get; set; }

        int PostId { get; set; }
        IBlogPost Post { get; set; }

        int CategoryId { get; set; }
        ITag Category { get; set; }
    }
}
