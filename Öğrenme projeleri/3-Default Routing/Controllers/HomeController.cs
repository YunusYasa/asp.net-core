using Microsoft.AspNetCore.Mvc;

namespace Default_Routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string About()
        {
            return "Hakkımızda";
        }
    }
}
