using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Usuarios
    {
        private CD_Usuarios objCDUsuarios = new CD_Usuarios();

        public List<Usuario> Listar()
        {
            return objCDUsuarios.Listar();
        }
    }
}
