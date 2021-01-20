using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes( RouteCollection routes )
        {
            routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", // Ex: movies/edit/1 => MoviesController and Edit(int id)
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }// If the url is not like the right format, it will pass to the HomeController, Index()
            );
        }
    }
}
