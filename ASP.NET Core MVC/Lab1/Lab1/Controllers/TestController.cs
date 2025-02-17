using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class TestController : Controller
    {
        // 1
        public string Display()
        {
            return "Welcome To MVC";
        }

        // 2
        public ViewResult Show()
        {
            return View();
        }


        // 3
        public ViewResult ShowAdd()
        {
            return View();
        }

        public int ShowResult(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
