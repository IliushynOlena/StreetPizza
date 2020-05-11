using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StreetPizza.Data.Models;
using StreetPizza.ViewModels;

namespace StreetPizza.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdministrationController(
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        //Get all roles
        [HttpGet]
        public IActionResult ListRoles()
            => View(_roleManager.Roles);

        //Create role
        [HttpGet]
        public IActionResult CreateRole()
            => View();


        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                //створюємо нову роль і пробуємо додати в таблицю
                var role = new IdentityRole
                {
                    Name = model.RoleName
                };

                var result = await _roleManager.CreateAsync(role);

                //якщо успішно - повертаємось на головну
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administration");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        //Edit role
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            //шукаємо роль по id
            //якщо знаходимо, то створюємо модель
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("Not Found");
            }

            var model = new EditRoleViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name
            };

            //перебираємо всіх юзерів, якщо співпадають з ролю - додаємо в модель
            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name)) ;
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }
    }
}