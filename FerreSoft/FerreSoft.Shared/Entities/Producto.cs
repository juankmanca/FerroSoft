namespace FerreSoft.Shared.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string? nombre { get; set; }
        public float valorUnitario { get; set; }
        public string? medida { get; set; }
        public string? unidadMedida { get; set; }
        public float peso { get; set; }
        public string? volumen { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaActualizacion { get; set; }
    }
}
