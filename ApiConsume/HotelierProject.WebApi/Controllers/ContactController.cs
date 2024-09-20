using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]

        public IActionResult SendMessage(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.InsertT(contact);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetContactInboxList()
        {
            var values =  _contactService.GetListT();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetMessageDetailsById(int id)
        {
            var values = _contactService.GetByIdT(id);
            return Ok(values);
        }
    }
}
