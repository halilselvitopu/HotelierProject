using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        //[HttpGet]
        //public IActionResult UserListWithLocation()
        //{
        //    var values = _appUserService.GetUsersWithLocationT();
        //    return Ok(values);
        //}

        [HttpGet]
        public IActionResult AppUserList()
        {
            var values = _appUserService.GetListT();
            return Ok(values);
        }
    }
}
