﻿using System.Web.Mvc;
using System.Web.Routing;

namespace ConeBrewing.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Beers",
                url: "Beer/{id}",
                defaults: new { controller = "Beer", action = "Details" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Calculator", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}