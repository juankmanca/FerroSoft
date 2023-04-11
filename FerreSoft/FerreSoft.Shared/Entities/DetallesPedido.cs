namespace FerreSoft.Shared.Entities
{
    public class DetallesPedido
    {
        public int id { get; set; }
        public int cantidad { get; set; }

        public int idPedido { get; set; }

        public int idProducto { get; set; }
        public Pedido? pedido { get; set;}

        public Producto? producto { get; set; }
    }
}
