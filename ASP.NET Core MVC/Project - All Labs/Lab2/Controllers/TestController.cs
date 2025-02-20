using Microsoft.AspNetCore.Mvc;
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

    }
}
