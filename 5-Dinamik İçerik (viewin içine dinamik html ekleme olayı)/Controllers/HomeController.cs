using Microsoft.AspNetCore.Mvc;

namespace Dinamik_İçerik__viewin_içine_dinamik_html_ekleme_olayı_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filmBasligi = "Dark Knight";
            string filmAciklama = "Joker ve Batman";
            string filmYonetmen = "Nolan";
            string[] oyuncular = {"oyuncu 1","oyuncu 2","oyuncu 3", "oyuncu 4"};

            ViewBag.FilmBaligi = filmBasligi;
            ViewBag.FilmAciklama = filmAciklama;
            ViewBag.FilmYonetmen = filmYonetmen;
            ViewBag.Oyuncular = oyuncular;


            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
