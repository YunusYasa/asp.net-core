using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult List(int? id)
        {
            var movies = MovieResponsitory.Movies;
            if (id != null)
            {
                movies = movies.Where(m=> m.GenreId == id).ToList();
            }
           
            var model = new MoviesViewModel()
            {
                Movies = movies
            };

            return View("Movies",model);
        }
        public IActionResult Details(int id)
        {
            return View (MovieResponsitory.GetById(id));
        }
    }
}
