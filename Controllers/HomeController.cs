using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller 
    {
        // localhost/home/index
        // localhost/home
        // localhost
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            // ViewBag.Selamlama = saat > 12 ? "İyi günler":"Günaydın";
            // ViewBag.UserName = "Mervan";

            ViewData["Selamlama"] = saat > 12 ? "İyi günler":"Günaydın";
            ViewData["UserName"] = "Mervan";
            
            return View();
        }
    }
}