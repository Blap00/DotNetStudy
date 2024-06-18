using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Categoria
    {
        private CD_Categoria objCDCategoria = new CD_Categoria();
        public List<Categoria> Listar()
        {
            return objCDCategoria.Listar();
        }
        public int GuardarCategoria(Categoria obj, out string Mensaje)
        {

            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje = "La Descripcion no puede estar vacio";
            }
            if (string.IsNullOrEmpty(Mensaje))
            {
                return objCDCategoria.GuardarCategoria(obj, out Mensaje);
            }
            else
            {
                return 0;
            }

        }
        public bool EditarCategoria(Categoria obj, out string Mensaje)
        {

            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje = "Lo nombres de Usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(Mensaje))
            {

                return objCDCategoria.EditarCategoria(obj, out Mensaje);
            }
            else
            {
                return false;
            }

        }
        public bool EliminarCategoria(int id, out string Mensaje)
        {
            return objCDCategoria.deleteCategoria(id, out Mensaje);
        }
    }
}
