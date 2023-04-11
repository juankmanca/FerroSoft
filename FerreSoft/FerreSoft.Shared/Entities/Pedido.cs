namespace FerreSoft.Shared.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public DateTime FechaCierre { get; set; }
        public float ValorTotal { get; set; }

        public int IdCliente { get; set; }

        public Cliente? Cliente { get; set; }
    }
}
