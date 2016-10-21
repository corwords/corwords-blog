using System;

namespace Corwords.Core.Blog
{
    // Borrowed from Shawn Wildermuth's project at https://github.com/shawnwildermuth/MetaWeblog/
    public class MetaWeblogException : Exception
    {
        public int Code { get; private set; }

        public MetaWeblogException(string message, int code = 1) : base(message)
        {
            Code = code;
        }
    }
}