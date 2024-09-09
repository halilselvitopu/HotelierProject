using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Default
{
    public class CarouselSliderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }

    }
}
