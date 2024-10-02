using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Dashboard
{
    public class AdminDashboardHeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
