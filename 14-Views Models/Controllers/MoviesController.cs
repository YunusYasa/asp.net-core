using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
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

            var turListesi = new List<Genre>()
            {
                new Genre { Name = "Aksiyon"},
                new Genre { Name = "Macera"},
                new Genre { Name = "Romantik"},
                new Genre { Name = "Bilim Kurgu"}
            };

            var model = new MovieGenreViewModel()
            {
                Movies = filmListesi,
                Genres = turListesi
            };

            return View("Movies",model);
        }
        public string Details()
        {
            return "Movies/Derails";
        }
    }
}
