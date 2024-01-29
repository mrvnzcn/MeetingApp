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
            return View();
        }
    }
}