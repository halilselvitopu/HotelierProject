using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.GetListT();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.InsertT(staff);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.GetByIdT(id);
            _staffService.DeleteT(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.UpdateT(staff);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffById(int id)
        {
            var values = _staffService.GetByIdT(id);
            return Ok(values);
        }
    }
}
