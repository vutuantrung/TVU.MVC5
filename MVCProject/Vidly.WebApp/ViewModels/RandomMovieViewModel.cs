using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.WebApp.Models;

namespace Vidly.WebApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}