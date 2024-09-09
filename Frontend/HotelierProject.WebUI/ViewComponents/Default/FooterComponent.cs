using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Default
{
    public class FooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View();
        }
    }
}
