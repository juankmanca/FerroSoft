namespace FerreSoft.Shared.Entities
{
    public class Stock
    {
        public int id { get; set; }
        public int cantidad { get; set; }

        public Pedido? pedido { get; set; }

        public int idPedido { get; set; }
    }
}
