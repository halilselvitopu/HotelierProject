using HotelierProject.EntityLayer;
using HotelierProject.WebUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Controllers
{
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
                UserName = createNewAppUserDto.Username
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
