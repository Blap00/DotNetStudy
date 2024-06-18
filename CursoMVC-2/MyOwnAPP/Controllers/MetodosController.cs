using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;

using CapaNegocios;

namespace MyOwnAPP.Controllers
{
    public class MetodosController : Controller
    {
        // GET: Metodos
        public ActionResult Categorias()
        {
            return View();
        }
        // CRUD CATEGORIAS

        //GET JSON RESULT;
        [HttpGet]
        public JsonResult ListarCategorias()
        {
            List<Categoria> oLista = new List<Categoria>();
            oLista = new CN_Categoria().Listar();

            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GuardarCategoria(Categoria obj)
        {
            object resultado;
            string Mensaje = string.Empty;

            if (obj.IdCategoria == 0)
            {
                resultado = new CN_Categoria().GuardarCategoria(obj, out Mensaje);
            }
            else
            {
                resultado = new CN_Categoria().EditarCategoria(obj, out Mensaje);
            }
            return Json(new { resultado = resultado, mensaje = Mensaje }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteCategoria(int id)
        {
            bool resultado;
            string Mensaje = string.Empty;

            resultado = new CN_Categoria().EliminarCategoria(id, out Mensaje);

            return Json(new { resultado = resultado, mensaje = Mensaje }, JsonRequestBehavior.AllowGet);
        }

        //END CRUD USUARIOS
        // END CRUD CATEGORIAS

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