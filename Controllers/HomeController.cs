using MeetingApp.Models;
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
            
            ViewData["Selamlama"] = saat > 12 ? "İyi günler":"Günaydın";
            // ViewData["UserName"] = "Mervan";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2024, 02, 10, 10, 0, 0),
                NumberOfPeople = 100
            };
            
            return View(meetingInfo);
        }
    }
}