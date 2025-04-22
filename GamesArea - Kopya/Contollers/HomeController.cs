using GamesArea.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamesArea.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string gameName = "Half-Life";
            string gameDevolopers = "Valve";
            string gamePlatforms = "Windows,PlayStation2,macOS,Linux";
            string[] gameGenres = { "First person shooter", "Action-adventure" };
            string imageUrl = "halflife.jpg";
            var model = new Game();

            model.Name = gameName;
            model.Devolopers = gameDevolopers;
            model.Platforms = gamePlatforms;
            model.Genres = gameGenres;
            model.ImageUrl = imageUrl;

            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
