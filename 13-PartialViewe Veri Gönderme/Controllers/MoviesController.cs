using Microsoft.AspNetCore.Mvc;
using PartialViews.Models;
using System.Collections;
using System.Collections.Generic;

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
            var filmListesi = new List<Movie>()
            {
                new Movie
                {
                    Title = "Film 1 ",
                    Description = "Açıklama 1",
                    Director = "Yönetmen 1",
                    Players = new string[]  {"Oyuncu 1","Oyuncu 2"},
                    ImgUrl = "1917.jpg",
                },
                new Movie
                {
                    Title = "Film 2 ",
                    Description = "Açıklama 2",
                    Director = "Yönetmen 2",
                    Players = new string[] { "Oyuncu 1", "Oyuncu 2" },
                    ImgUrl = "avatar.jpg",
                },
                new Movie
                {
                    Title = "Film 3 ",
                    Description = "Açıklama 3",
                    Director = "Yönetmen 3",
                    Players = new string[] { "Oyuncu 1", "Oyuncu 2" },
                    ImgUrl = "thor.jpg",
                }           

            };
            return View("Movies",filmListesi);
        }
        public string Details()
        {
            return "Movies/Derails";
        }
    }
}
