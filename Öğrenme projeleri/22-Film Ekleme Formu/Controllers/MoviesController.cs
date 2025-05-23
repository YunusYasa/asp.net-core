﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult List(int? id,string q)
        {
            var controller = RouteData.Values["controller"];
            var actions = RouteData.Values["action"];
            //var genreId = RouteData.Values["id"];

            var movies = MovieResponsitory.Movies;
            if (id != null)
            {
                movies = movies.Where(m=> m.GenreId == id).ToList();
            }
            if (! string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i =>
                i.Title.ToLower().Contains(q.ToLower()) ||
                i.Description.ToLower().Contains(q.ToLower())).ToList();
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

        public IActionResult Create()
        {
            return View();
        }
    }
}
