using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Marca
    {
        private CD_Marcas objCDMarca = new CD_Marcas();
        public List<Marca> Listar()
        {
            return objCDMarca.Listar();
        }
        public int GuardarMarca(Marca obj, out string Mensaje)
        {

            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje = "La Descripcion no puede estar vacio";
            }
            if (string.IsNullOrEmpty(Mensaje))
            {
                return objCDMarca.GuardarMarca(obj, out Mensaje);
            }
            else
            {
                return 0;
            }

        }
        public bool EditarMarca(Marca obj, out string Mensaje)
        {

            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje = "La descripcion de la marca no puede estar vacio";
            }
            if (string.IsNullOrEmpty(Mensaje))
            {

                return objCDMarca.EditarMarca(obj, out Mensaje);
            }
            else
            {
                return false;
            }

        }
        public bool EliminarMarca(int id, out string Mensaje)
        {
            return objCDMarca.deleteMarca(id, out Mensaje);
        }
    }
}
