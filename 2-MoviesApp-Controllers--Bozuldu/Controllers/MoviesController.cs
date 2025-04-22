using Microsoft.AspNetCore.Mvc;

namespace MoviesApp_Controllers.Controllers
{
    public class MoviesController : Controller
    {
        public string Index()
        {
            return "List index";
        }
        public string List()
        {
            return "List ekranı";
        }
       
        public string Details()
        {
            return "Detay ekranı";
        }
    }
}
