using Lab2.Models;
using Lab2.Repositries.Implementions;
using Lab2.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Lab2.Repositries.Interfaces;

namespace Lab2.Controllers
{
    public class AccountController : Controller
    {
         IUnitOfWork unitOfWork;
        public AccountController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                user.Roles.Add(new Role {Name = "Student" });
                unitOfWork.User.Add(user);
                
                unitOfWork.Complete();
                return View("Login");
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = unitOfWork.User.GetOne(e => e.Email == loginViewModel.Email && e.Password == loginViewModel.Password, new[] {"Roles"});
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Roles.FirstOrDefault()!.Name)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid email or password");
            }
            return View(loginViewModel);
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            
            return RedirectToAction("Login");
        }

    }
}
