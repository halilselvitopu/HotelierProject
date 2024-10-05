using HotelierProject.EntityLayer.Concrete;
using HotelierProject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Controllers
{
    public class AdminSettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminSettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UpdateUserViewModel updateUserViewModel = new UpdateUserViewModel()
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Username = user.UserName,

            };

            return View(updateUserViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UpdateUserViewModel updateUserViewModel)
        {
            if (updateUserViewModel.Password == updateUserViewModel.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);

                user.Name = updateUserViewModel.Name;
                user.Surname = updateUserViewModel.Surname;
                user.Email = updateUserViewModel.Email;
                user.Email = updateUserViewModel.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, updateUserViewModel.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
           


            return View();
           
        }
    }
}
