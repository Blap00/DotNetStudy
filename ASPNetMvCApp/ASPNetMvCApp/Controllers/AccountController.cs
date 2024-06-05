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
            string Password = form["Password"]
            if(command == "Loging")
            {
                return Redirect("/");
            }
            else
            {
                return View();
            }            
        }
    }
}
