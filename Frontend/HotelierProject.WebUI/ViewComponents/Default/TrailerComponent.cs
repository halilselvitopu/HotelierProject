using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Default
{
    public class TrailerComponent : ViewComponent
    {
         public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
