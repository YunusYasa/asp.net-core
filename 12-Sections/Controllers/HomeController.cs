using Microsoft.AspNetCore.Mvc;
using PartialViews.Models;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filmBasligi = "film başlığı";
            string filmAciklama = "film başlığı";
            string filmYonetmen = "film başlığı";
            string[] oyuncular = {"Oyuncu1","Oyuncu2","Oyuncu3"};

            Movie m = new Movie();

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
