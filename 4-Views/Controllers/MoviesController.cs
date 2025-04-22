using Microsoft.AspNetCore.Mvc;

namespace Views.Controllers
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
        public string Details()
        {
            return "detaiils";
        }
    }
}
