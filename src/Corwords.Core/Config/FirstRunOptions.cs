using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Config
{
    public class FirstRunOptions
    {
        public bool FirstRunEnabled { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
    }
}
