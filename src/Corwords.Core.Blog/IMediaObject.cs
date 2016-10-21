using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Blog
{
    public interface IMediaObject
    {
        int Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        string Bits { get; set; }
    }
}
