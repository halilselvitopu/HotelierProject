using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.GetListT();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {

            _guestService.InsertT(guest);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.GetByIdT(id);
            _guestService.DeleteT(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.UpdateT(guest);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetGuestById(int id)
        {
            var values = _guestService.GetByIdT(id);
            return Ok(values);
        }
    }
}
