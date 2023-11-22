using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using template.Models;
using Microsoft.EntityFrameworkCore;
using template.Data;

namespace template.Controllers
{
    public class HomeController : Controller
    {

        private AaContext db;

        public HomeController(AaContext db)
        {
            this.db = db;
        }
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

        public IActionResult Logout()
        {
            if(HttpContext.Session.GetString("name") != null)
            {
                HttpContext.Session.Remove("name");
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Users()
        {
            return View(await db.Users.ToListAsync());
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (user != null)
            {
                db.Add(user);
                db.SaveChanges();
                return RedirectToAction(nameof(Users));
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            User users = db.Users.Find(id);
            return View(users);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (user != null)
            {
                db.Update(user);
                db.SaveChanges();
                return RedirectToAction(nameof(Users));
            }
            return View(user);
        }

        public IActionResult Delete(int id)
        {
            User users = db.Users.Find(id);
            db.Users.Remove(users);
	    db.SaveChanges();
            return RedirectToAction(nameof(Users));
        }
    }
}