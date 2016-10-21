using System;

namespace Corwords.Core.Blog
{
    public class XmlRpcMethodAttribute : Attribute
    {
        public XmlRpcMethodAttribute(string methodName)
        {
            MethodName = methodName;
        }

        public string MethodName { get; set; }
    }
}