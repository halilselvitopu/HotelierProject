using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.Dtos.RoomDto;
using HotelierProject.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.GetListT();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {

            _roomService.InsertT(room);
             return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.GetByIdT(id);
            _roomService.DeleteT(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.UpdateT(room);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoomById(int id)
        {
            var values =  _roomService.GetByIdT(id);
            return Ok(values);
        }
    }
}
