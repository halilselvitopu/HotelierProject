using HotelierProject.EntityLayer.Concrete;
using HotelierProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleAssignController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<AssignRoleViewModel> assignRoleViewModels = new List<AssignRoleViewModel>();
            foreach (var item in roles)
            {
                AssignRoleViewModel assignRoleViewModel = new AssignRoleViewModel();
                assignRoleViewModel.RoleId = item.Id;
                assignRoleViewModel.RoleName = item.Name;
                assignRoleViewModel.RoleExist = userRoles.Contains(item.Name);
                assignRoleViewModels.Add(assignRoleViewModel);
                
            }
            return View(assignRoleViewModels);
        }
    }
}
