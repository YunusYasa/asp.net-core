using Microsoft.AspNetCore.Mvc;
using GamesArea.Models;
using System.Collections.Generic;

namespace GamesArea.Contollers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {          
            return View();
        }
        public IActionResult List()
        {
            var gamesList = new List<Game>()
            {
                new Game()
                {
                    Name = "Half-Life",
                    Devolopers = "Valve",
                    Platforms = "Windows,PlayStation2,macOS,Linux",
                    Genres = new string[] { "First person shooter", "Action-adventure" },
                    ImageUrl ="halfLife.jpg"

                },
                new Game()
                {
                    Name = "Fallout 3",
                    Devolopers = "Bethesda Game Studios",
                    Platforms = "PlayStation 3,Windows,Xbox 360",
                    Genres = new string[] { "Role playing", "Action role-playing" },                   
                    ImageUrl ="fallout3.jpg"

                },new Game()
                {
                    Name = "Minecraft",
                    Devolopers = "Mojang Studios",
                    Platforms = "Windows,macOS,Linux",
                    Genres = new string[] { "Sandbox", "Survival" },
                    ImageUrl ="minecraft.jpg"
                }
            };


            return View(gamesList);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
