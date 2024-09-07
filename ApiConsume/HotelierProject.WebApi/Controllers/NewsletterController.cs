using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsletterController : ControllerBase
    {
        private readonly INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpGet]
        public IActionResult NewsletterList()
        {
            var values = _newsletterService.GetListT();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddNewsletter(Newsletter newsletter)
        {
            _newsletterService.InsertT(newsletter);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteNewsletter(int id)
        {
            var values = _newsletterService.GetByIdT(id);
            _newsletterService.DeleteT(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateNewsletter(Newsletter newsletter)
        {
            _newsletterService.UpdateT(newsletter);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetNewsletterById(int id)
        {
            var values = _newsletterService.GetByIdT(id);
            return Ok(values);
        }
    }
}
