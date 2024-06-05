using ASPNetMvCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMvCApp.Controllers
{
    public class AccountController : Controller
    {  
        // REGISTER
        [HttpGet]
        
        public IActionResult UserSignup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserSignup(LoginModel model)
        {
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
