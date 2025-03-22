using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> AddRoles()
        {
            var role1 = new IdentityRole { Name = "Admin" };
            var role2 = new IdentityRole { Name = "Employee" };
            var role3 = new IdentityRole { Name = "Student" };

            await _roleManager.CreateAsync(role1);
            await _roleManager.CreateAsync(role2);
            await _roleManager.CreateAsync(role3);

            var model = _roleManager.Roles.ToList();
            return View("Roles", model);
        }

        public async Task<IActionResult> CreateUser()
        {
            ApplicationUser user = new ApplicationUser();
            user.FirstName = "Ahmed";
            user.LastName = "Mohamed";
            user.Email = "Ahmed@gmail.com";
            user.UserName = "A.Mohammed";
            user.Age = 30;
            var result = await _userManager.CreateAsync(user, "123456aA#");
            if (result.Succeeded)
            {
               var roleResult = await _userManager.AddToRoleAsync(user, "Admin");
                if (roleResult.Succeeded)
                {
                    var model = _userManager.Users.ToList();
                    return View("Users", model);
                }
                else
                {
                    return Content($"Error In Role : {roleResult.Errors.FirstOrDefault()!.Description}");
                }
            }
            else
            {
                return Content($"User Result: {result.Errors.FirstOrDefault()!.Description}");
            }
        }

        public IActionResult Index()
        {
            var model = _userManager.Users.ToList();
            return View("Users", model);
        }

        [HttpGet]
        public async Task<IActionResult> ManageRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var rolesIn = (await _userManager.GetRolesAsync(user!)).ToList();
            var allRoles = _roleManager.Roles.Select(e => e.Name).ToList();
            var rolesOut = allRoles.Except(rolesIn);
            ViewBag.Id = id;
            ViewBag.RolesIn = rolesIn;
            ViewBag.RolesOut = rolesOut;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ManageRoles(string id, string[] rolesToRemove, string[] rolesToAdd)
        {
            var user = await _userManager.FindByIdAsync(id);
            await _userManager.RemoveFromRolesAsync(user, rolesToRemove);
            await _userManager.AddToRolesAsync(user, rolesToAdd);
            return RedirectToAction("Index");
        }
    }
}
