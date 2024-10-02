using HotelierProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgets : ControllerBase
    {
        private readonly IStaffService _staffService;

        public DashboardWidgets(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet("GetStaffCount")]
        public IActionResult GetStaffCount()
        {
            var value = _staffService.GetStaffCountT();
            return Ok(value);
        }
    }
}
