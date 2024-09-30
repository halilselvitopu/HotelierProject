using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWithWorkLocationController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
    public AppUserWithWorkLocationController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var values = _appUserService.GetUsersWithLocationsT();
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWithWorkLocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationId = y.WorkLocationId,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                Gender = y.Gender,
                ImageUrl = y.ImageUrl,
                Country = y.Country,
            }).ToList();
            return Ok(values);
        }
    }
}
