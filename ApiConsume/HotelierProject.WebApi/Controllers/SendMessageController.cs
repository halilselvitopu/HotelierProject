﻿using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendMessageService.GetListT();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.InsertT(sendMessage);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _sendMessageService.GetByIdT(id);
            _sendMessageService.DeleteT(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.UpdateT(sendMessage);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessageById(int id)
        {
            var values = _sendMessageService.GetByIdT(id);
            return Ok(values);
        }

        [HttpGet("GetSendMessageCount")]
        public IActionResult GetSendMessageCount()
        {
            
            return Ok(_sendMessageService.GetContactCountT());
        }
    }
}
