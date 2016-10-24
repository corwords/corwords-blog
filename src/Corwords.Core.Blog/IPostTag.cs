using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface IPostTag<TSelf>
        where TSelf : IPostTag<TSelf>
    {
        int PostTagId { get; set; }

        int PostId { get; set; }
        IBlogPost<TSelf> Post { get; set; }

        int TagId { get; set; }
        ITag<TSelf> Tag { get; set; }
    }
}
