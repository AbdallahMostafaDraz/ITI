using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pivacy()
        {
            return View();
        }
    }
}
