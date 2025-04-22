using Microsoft.AspNetCore.Mvc;
using Model_List.Models;

namespace Model_List.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filmBasligi = "Dark Knight";
            string filmAciklama = "Joker ve Batman";
            string filmYonetmen = "Nolan";
            string[] oyuncular = { "oyuncu 1", "oyunucu 2", "oyuncu 99" };

            ViewBag.FilmBaligi = filmBasligi;
            ViewBag.FilmAciklama = filmAciklama;
            ViewBag.FilmYonetmen = filmYonetmen;
            ViewBag.Oyuncular = oyuncular;

            var m = new Movie();

            m.Title = filmBasligi;
            m.Description = filmAciklama;
            m.Director = filmYonetmen;
            m.Players = oyuncular;


            return View(m);
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
