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
            //if (string.IsNullOrEmpty(model.Name))
            //{
            //    ModelState.AddModelError("Name", "Please, enter a correct name to it.");
            //}
            //if (string.IsNullOrEmpty(model.Username))
            //{
            //    ModelState.AddModelError("Username", "Please, enter a correct username to it.");
            //}
            //if (string.IsNullOrEmpty(model.Password))
            //{
            //    ModelState.AddModelError("Password", "Please, enter a correct password to it.");
            //}
            //if (string.IsNullOrEmpty(model.ConfirmPassword))
            //{
            //    ModelState.AddModelError("ConfirmPassword", "Please, enter a correct password to it.");
            //}
            //if(!string.Equals(model.Password, model.ConfirmPassword))
            //{
            //    ModelState.AddModelError("ConfirmPassword", "Please, be aware, the password must match.");
            //}
            //if (string.IsNullOrEmpty(model.Contact))
            //{
            //    ModelState.AddModelError("Contact", "Please, enter a correct contact to it.");
            //}
            //if (!model.Terms)
            //{
            //    ModelState.AddModelError("Terms", "Please, agree with TERMS & CONDITION");
            //}
            if (ModelState.IsValid)
            {
                return Redirect("/Account/Login");
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
