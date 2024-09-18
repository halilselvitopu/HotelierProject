using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Booking
{
    public class BookingCoverComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
