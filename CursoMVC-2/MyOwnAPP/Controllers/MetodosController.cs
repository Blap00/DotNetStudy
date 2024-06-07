using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyOwnAPP.Controllers
{
    public class MetodosController : Controller
    {
        // GET: Metodos
        public ActionResult Categorias()
        {
            return View();
        }
        public ActionResult Marcas()
        {
            return View();
        }
        public ActionResult Productos()
        {
            return View();
        }
        public ActionResult Ventas()
        {
            return View();
        }
    }
}