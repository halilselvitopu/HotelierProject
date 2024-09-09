using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.GetListT();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.InsertT(about);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.GetByIdT(id);
            _aboutService.DeleteT(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.UpdateT(about);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAboutById(int id)
        {
            var values = _aboutService.GetByIdT(id);
            return Ok(values);
        }
    }
}
