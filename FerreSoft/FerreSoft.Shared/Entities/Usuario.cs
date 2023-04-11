namespace FerreSoft.Shared.Entities
{
    public class Usuario
    {
        public int id { get; set; }
        public string? nombre { get; set; }

        public string? tipoDocumento { get; set; }

        public string? documento { get; set; }
        public string? correo { get; set; }
        public string? telefono { get; set; }
        public string? direccion { get; set; }
        public string? departamento { get; set; }
        public string? ciudad { get; set; }
        public string? barrio { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public bool activo { get; set; }

    }
}
