using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface IPostTag<TSelf>
        where TSelf : IPostTag<TSelf>
    {
        int PostCategoryId { get; set; }

        int PostId { get; set; }
        IBlogPost<TSelf> Post { get; set; }

        int CategoryId { get; set; }
        ITag<TSelf> Category { get; set; }
    }
}
