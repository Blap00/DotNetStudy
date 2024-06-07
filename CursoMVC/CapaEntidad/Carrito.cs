namespace CapaEntidad
{
    class Carrito
    {
        public int IdCarrito { get; set; }
        public Cliente oIdCliente { get; set; }
        public Producto oIdProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
