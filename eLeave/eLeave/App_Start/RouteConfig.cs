using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eLeave
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name:"Board",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Board", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Register",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Board", action = "Register", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "ApplyLeave",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Board", action = "ApplyLeave", id = UrlParameter.Optional }
                );

           

            routes.MapRoute(
                name: "test",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "test", action = "test", id = UrlParameter.Optional }
                );
        }
    }
}
