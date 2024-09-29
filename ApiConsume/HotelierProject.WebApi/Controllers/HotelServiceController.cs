using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelServiceController : ControllerBase
    {
         private readonly IHotelServiceService _hotelService;

        public HotelServiceController(IHotelServiceService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public IActionResult HotelServiceList()
        {
            var values = _hotelService.GetListT();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddHotelService(HotelService hotelService)
        {
            _hotelService.InsertT(hotelService);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHotelService(int id)
        {
            var values = _hotelService.GetByIdT(id);
            _hotelService.DeleteT(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateHotelService(HotelService hotelService)
        {
            _hotelService.UpdateT(hotelService);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetHotelServiceById(int id)
        {
            var values = _hotelService.GetByIdT(id);
            return Ok(values);
        }
    }
}
