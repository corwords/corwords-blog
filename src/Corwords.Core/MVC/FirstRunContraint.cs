using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Corwords.Core.Config;

namespace Corwords.Core.MVC
{
    public class FirstRunContraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var options = httpContext.RequestServices.GetService(typeof(IOptions<FirstRunOptions>));
            return (options as IOptions<FirstRunOptions>).Value.FirstRunEnabled;
        }
    }
}
