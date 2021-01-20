using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly.WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes( RouteCollection routes )
        {
            routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );

            routes.MapMvcAttributeRoutes();

            // Custom route
            //routes.MapRoute(
            //    "MoviesByReleasedDate",
            //    "movies/released/{year}/{month}",
            //    new {controller = "Movies", action = "ByReleasedDate"},
            //    new {year=@"\d{4}", month= @"\d{2}" }
            //    //new { year = @"2015|2016", month = @"\d{2}" }
            //);

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}", // Ex: movies/edit/1 => MoviesController and Edit(int id)
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }// If the url is not like the right format, it will pass to the HomeController, Index()
            );
        }
    }
}
