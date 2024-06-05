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
        public IActionResult UserLogin(String Username, String Password)
        {
            if(Username=="Pass" && Password == "Data")
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
