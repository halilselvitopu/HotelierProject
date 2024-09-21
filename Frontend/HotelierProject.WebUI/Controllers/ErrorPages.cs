using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ErrorPages : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
