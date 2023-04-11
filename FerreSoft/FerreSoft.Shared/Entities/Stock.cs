namespace FerreSoft.Shared.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public Pedido? Pedido { get; set; }

        public int idPedido { get; set; }
    }
}
