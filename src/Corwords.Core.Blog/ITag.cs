using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface ITag
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime DateCreated { get; set; }
        IList<IPostTag> PostTags { get; set; }
    }
}
