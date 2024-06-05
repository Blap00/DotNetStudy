using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMvCApp.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            //TODO: Fetch data from DBA

            List<string> data = new List<string> { "Good One", "Great!", "Bad video!", "I haven't seen that part @1;35" };
            return View("~/views/shared/_comments.cshtml", data);
//            return View(data);
        }            
    }
}
