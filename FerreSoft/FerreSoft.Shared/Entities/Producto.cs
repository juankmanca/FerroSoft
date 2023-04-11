namespace FerreSoft.Shared.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public float ValorUnitario { get; set; }
        public string? Medida { get; set; }
        public string? UnidadMedida { get; set; }
        public float Peso { get; set; }
        public string? Volumen { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
