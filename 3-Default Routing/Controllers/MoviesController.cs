using Microsoft.AspNetCore.Mvc;

namespace Default_Routing.Controllers
{
    public class MoviesController : Controller
    {
        public string Index()
        {
            return "Movie index";
        }
        public IActionResult List()
        {
            return View("Movies");
        }
        public string Details()
        {
            return "Detay ekranı";
        }
    }
}
