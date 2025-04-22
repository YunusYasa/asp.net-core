using Microsoft.AspNetCore.Mvc;

namespace Dinamik_İçerik__viewin_içine_dinamik_html_ekleme_olayı_.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult List()
        {
            return View("Movies");
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
