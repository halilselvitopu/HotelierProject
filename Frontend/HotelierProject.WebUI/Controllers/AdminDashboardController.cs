using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
