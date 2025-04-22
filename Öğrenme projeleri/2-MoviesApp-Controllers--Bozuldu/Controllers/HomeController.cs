using Microsoft.AspNetCore.Mvc;

namespace MoviesApp_Controllers.Controllers
{
    public class HomeController : Controller
    {
        
        public string Index()
        {
            return "Anasayfa";
        }
        
        public string About()
        {
            return "Hakkımızda";
        }
    }
}
