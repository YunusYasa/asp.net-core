using Microsoft.AspNetCore.Mvc;
using Model_List.Models;
using System;
using System.Collections.Generic;

namespace Model_List.Controllers
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
                },
                new Movie
                {
                    Title = "Film 2 ",
                    Description = "Açıklama 2",
                    Director = "Yönetmen 2",
                    Players = new string[]  {"Oyuncu 1","Oyuncu 2"},
                },
                new Movie
                {
                    Title = "Film 3 ",
                    Description = "Açıklama 3",
                    Director = "Yönetmen 3",
                    Players = new string[]  {"Oyuncu 1","Oyuncu 2"},
                },
                new Movie
                {
                    Title = "Film 4 ",
                    Description = "Açıklama 4",
                    Director = "Yönetmen 4",
                    Players = new string[]  {"Oyuncu 1","Oyuncu 2"},
                }

            };
            return View("Movies",filmListesi);
        }
        public string Details()
        {
            return "details/movies";
        }
    }
}
