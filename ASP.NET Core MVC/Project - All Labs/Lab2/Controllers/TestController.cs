using Lab2.Models.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DownloadFile()
        {
            return File("~/MyFile.txt", "text/plain", "FileDownloaded");
        }

        public IActionResult ReturnJson()
        {
            var jsonContent = new { Id = 1, Name = "Abdallah Mostafa", Age = 24 };
            return Json(jsonContent);   
        }

        public IActionResult Google()
        {
            return Redirect("https://www.google.com");
        }

        [MyExceptionFilter]
        public IActionResult ActionFilter()
        {
            // This Will Throw Exception
            int x = int.Parse("abc");  
            return Content(x.ToString());
        }
        static bool flag = false;
        public IActionResult ChangeLayout()
        {
            if (!flag)
            {
                TempData["Layout"] = "_Layout2";
                flag = true;
            }
            else
            {
                TempData["Layout"] = "_Layout";
                flag = false;
            }
            return View("Index");
        }
    }
}
