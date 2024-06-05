using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMvCApp.Controllers
{
    public class ProductController : Controller
    {
        //We use Route to declare, if the next ROUTE is selected, do this inmediatly
        [Route("Product/index/{id}/{catId}")]
        public IActionResult Index(int id, int catId)
        {
            if (id == 1 && catId == 1)
            {
                return View("Index");
            }
            else
            {
                return View("Data");
            }
        }
        [Route("Product/IndexData/{id}/{catId}")]
        public IActionResult IndexData(int id, int catId)
        {
            
            return View("Data");
            
        }
    }
}
