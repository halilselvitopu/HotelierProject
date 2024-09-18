using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Contact
{
    public class ContactCoverComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
