using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using template.Models;

namespace template.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            ViewBag.username = HttpContext.Session.GetString("name");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult Demo(int num)
        {
            ViewBag.num = num;    
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            if(form["username"] == "Admin" && form["password"] == "Admin")
            {
                HttpContext.Session.SetString("name", form["username"]);
                
                return RedirectToAction(nameof(Index));
            }
            
            return View();
        }
    }
}