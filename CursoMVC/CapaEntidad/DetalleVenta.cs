using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public Venta oIdVenta { get; set; }
        public Producto oIdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }


    }
}
