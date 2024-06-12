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
        //CRUD USUARIOS
        //GET JSON RESULT;
        [HttpGet]
        public JsonResult ListarUsuarios()
        {
            List<Usuario> oLista = new List<Usuario>();
            oLista = new CN_Usuarios().Listar();

            return Json(new { data= oLista }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GuardarUsuario(Usuario obj)
        {
            object resultado;
            string Mensaje=string.Empty;

            if (obj.IdUsuario == 0)
            {
                resultado = new CN_Usuarios().GuardarUsuario(obj, out Mensaje);
            }
            else
            {
                resultado = new CN_Usuarios().EditarUsuario(obj, out Mensaje);
            }
            return Json(new { resultado = resultado, mensaje = Mensaje }, JsonRequestBehavior.AllowGet);
        }
        //END CRUD USUARIOS
    }
}