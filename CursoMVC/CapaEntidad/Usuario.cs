using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres{ get; set; }
        public string Apellidoss { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Restablecer { get; set; }
        public bool Activo{ get; set; }

    }
}
