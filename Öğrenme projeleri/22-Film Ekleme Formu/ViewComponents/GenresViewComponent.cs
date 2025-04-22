using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using View_Components.Data;
using View_Models.Models;

namespace View_Components.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];

            return View(GenreResponsitory.Genre);
        }
    }
}
