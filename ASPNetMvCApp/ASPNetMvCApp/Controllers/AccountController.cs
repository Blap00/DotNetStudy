using ASPNetMvCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ASPNetMvCApp.Controllers
{
    public class AccountController : Controller
    {  
        //INDEX TESTING
        public IActionResult Index()
        {
            string Name = (string)TempData.Peek("Name");
            string Message = (string)TempData["Message"];

            string nopersistant = Request.Cookies["non-persistant"];
            string persistant = Request.Cookies["persistant"];

            string name = HttpContext.Session.GetString("Name");
            string user = HttpContext.Session.GetString("User");

            LoginModel model = JsonSerializer.Deserialize<LoginModel>(user);

            return View();
        }


        // REGISTER
        [HttpGet]
        public IActionResult UserSignup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserSignup(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //TEMP DATA WORKS ONLY WHEN IT PASS THERE, IF IT DOESN'T EXIST IT WILL DELEETE ITSELF
                TempData["Name"] = model.Name;
                TempData["Message"] = "Welcome back " + model.Name + "!";

                // Non persistent cookie:
                Response.Cookies.Append("non-persisten", "my non-persistant cookie");

                // Persistant cookie (MOST SAFE FOR USERS)
                var options = new CookieOptions { Expires = DateTime.Now.AddDays(7) };
                Response.Cookies.Append("persistant", "persistant cookie!", options);

                // Strin Serializer;
                string strData = JsonSerializer.Serialize(model);

                // ADD SESSION
                HttpContext.Session.SetString("Name", "Name");
                HttpContext.Session.SetString("User", strData);


                //TODO: APPLY A REAL DBA:
                return RedirectToAction("Index", "Account");
            }
            return View();
        }

        // LOGIN
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserLogin(IFormCollection form)
        {
            string command = form["Command"];
            string Username = form["Username"];
            string Password = form["Password"];
            if (command == "Login")
            {
                return Redirect("/");
            }
            else if (command == "Signup")
            {
                return Redirect("/Account/UserSignup");
            }
            else
            {
                return View();
            }
        }


    }
}
