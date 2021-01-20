using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};

            // Why we can return View instead of ActionResult, bc ActionResult has many types of result ?
            // Explanation: https://www.c-sharpcorner.com/article/action-result-in-asp-net-mvc/#:~:text=Action%20Result%20is%20actually%20a,of%20action%20when%20it%20executes.
            // The ActionResult is an abstract class

            //return Content("Hello world.");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction( "Index", "Home", new { page = 1, sortBy = "name" } );

            // 2 way to pass data to view, but we need to change the property's name in 2 files ("Movie")
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model <- movie will be assigned into ViewData dictionary

            return View( movie );
        }

        public ActionResult Edit(int movieId)
        {
            // Like this we can pass ~/movies/edit?movieId=1 => works
            // But it will not work with ~movies/edit/1, bc the default parameter is id (Look at in RouteConfig.cs)
            return Content("id=" + movieId);
        }

        // Return a view which display the list of movies in DB
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            // movies/index?pageIndex=1&sortBy="unknown"
            if (!pageIndex.HasValue) pageIndex = 1;
            if (string.IsNullOrEmpty(sortBy)) sortBy = "Name";

            return Content($@"Page index = {pageIndex}, sort by = {sortBy}");
        }

        // Attribute routing
        // https://devblogs.microsoft.com/aspnet/attribute-routing-in-asp-net-mvc-5/
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            // movies/released/{year}/{month}
            return Content($@"Released year: {year}, month: {month}");
        }
    }
}