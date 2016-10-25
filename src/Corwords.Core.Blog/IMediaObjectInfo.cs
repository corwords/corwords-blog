using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface IMediaObjectInfo
    {
        int Id { get; set; }
        string Url { get; set; }
    }
}
