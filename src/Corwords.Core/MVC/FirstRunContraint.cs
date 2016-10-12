using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Corwords.Core.MVC
{
    public class FirstRunContraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var firstRunKey = "firstRunEnabled";
            if (values.ContainsKey(firstRunKey))
            {
                var isFirstRunEnabled = false;
                bool.TryParse(values[firstRunKey].ToString(), out isFirstRunEnabled);

                if (isFirstRunEnabled)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
