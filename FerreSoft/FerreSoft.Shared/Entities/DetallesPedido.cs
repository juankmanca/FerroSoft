namespace FerreSoft.Shared.Entities
{
    public class DetallesPedido
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public int IdPedido { get; set; }

        public int IdProducto { get; set; }
        public Pedido? Pedido { get; set;}

        public Producto? Producto { get; set; }
    }
}
