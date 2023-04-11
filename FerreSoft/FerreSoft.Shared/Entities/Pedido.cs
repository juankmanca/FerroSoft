namespace FerreSoft.Shared.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public DateTime fechaCierre { get; set; }
        public float valorTotal { get; set; }

        public int idCliente { get; set; }

        public Cliente? Cliente { get; set; }
    }
}
