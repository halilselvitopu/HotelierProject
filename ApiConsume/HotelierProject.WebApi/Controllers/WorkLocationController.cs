using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
        {
            private readonly IWorkLocationService _workLocationService;

            public WorkLocationController(IWorkLocationService workLocationService)
            {
                _workLocationService = workLocationService;
            }

            [HttpGet]
            public IActionResult WorkLocationList()
            {
                var values = _workLocationService.GetListT();
                return Ok(values);
            }

            [HttpPost]
            public IActionResult AddWorkLocation(WorkLocation WorkLocation)
            {
                _workLocationService.InsertT(WorkLocation);
                return Ok();
            }

            [HttpDelete("{id}")]
            public IActionResult DeleteWorkLocation(int id)
            {
                var values = _workLocationService.GetByIdT(id);
                _workLocationService.DeleteT(values);
                return Ok();
            }

            [HttpPut]
            public IActionResult UpdateWorkLocation(WorkLocation WorkLocation)
            {
                _workLocationService.UpdateT(WorkLocation);
                return Ok();
            }

            [HttpGet("{id}")]
            public IActionResult GetWorkLocationById(int id)
            {
                var values = _workLocationService.GetByIdT(id);
                return Ok(values);
            }
        }
}
