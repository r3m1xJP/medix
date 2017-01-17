using MedixCollege.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MedixCollege
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Add("NewsArticle", new SeoFriendlyRoute("Home/NewsArticle/{id}",
             new RouteValueDictionary(new { controller = "Home", action = "NewsArticle" }),
             new MvcRouteHandler()));

            routes.MapRoute(
                name: "ThankYou",
                url: "ThankYou",
                defaults: new { controller = "External", action = "ThankYou" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
