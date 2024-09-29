using HotelierProject.EntityLayer.Concrete;
using HotelierProject.WebUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index (CreateNewAppUserDto createNewAppUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var AppUser = new AppUser()
            {

                Name = createNewAppUserDto.Name,
                Email = createNewAppUserDto.Mail,
                Surname = createNewAppUserDto.Surname,
                UserName = createNewAppUserDto.Username,
                WorkLocationId = 1
            };
            var result  = await _userManager.CreateAsync(AppUser,createNewAppUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
