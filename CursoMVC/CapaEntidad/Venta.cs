using System.Collections.Generic;

namespace CapaEntidad
{
    class Venta
    {
        public int IdVenta { get; set; }
        public Cliente oIdCliente { get; set; }
        public int TotalProducto { get; set; }
        public float MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string IdDistrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int IdTransaccion { get; set; }

        public List<DetalleVenta> oDetalleVenta { get; set; }
    }
}
