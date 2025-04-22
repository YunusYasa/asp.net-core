using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using View_Models.Models;

namespace View_Components.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var turListesi = new List<Genre>()
            {
                new Genre { Name = "Aksiyon"},
                new Genre { Name = "Macera"},
                new Genre { Name = "Romantik"},
                new Genre { Name = "Bilim Kurgu"}
            };

            return View(turListesi);
        }
    }
}
