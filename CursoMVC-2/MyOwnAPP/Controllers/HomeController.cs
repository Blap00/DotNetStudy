using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;

using CapaNegocios;

namespace MyOwnAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Usuarios()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult Terms()
        {
            return View();
        }

        //GET JSON RESULT;
        [HttpGet]
        public JsonResult ListarUsuarios()
        {
            List<Usuario> oLista = new List<Usuario>();
            oLista = new CN_Usuarios().Listar();

            return Json(new { data= oLista }, JsonRequestBehavior.AllowGet);
        }
    }
}