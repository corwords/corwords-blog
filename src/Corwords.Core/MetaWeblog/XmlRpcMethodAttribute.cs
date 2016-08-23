﻿using System;

namespace Corwords.Core.MetaWeblog
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