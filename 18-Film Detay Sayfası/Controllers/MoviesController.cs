using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using View_Components.Data;
using View_Models.Models;

namespace PartialViews.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {

            var model = new MoviesViewModel()
            {
                Movies = MovieResponsitory.Movies
            };

            return View("Movies",model);
        }
        public IActionResult Details(int id)
        {
            return View (MovieResponsitory.GetById(id));
        }
    }
}
