using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using View_Components.Data;

using View_Models.Models;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                PopularMovies = MovieResponsitory.Movies
            };
            return View(model);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
