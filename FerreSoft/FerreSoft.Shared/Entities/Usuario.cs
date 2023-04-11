namespace FerreSoft.Shared.Entities
{
    public class Usuario
    {
        public int id { get; set; }
        public string?  Nombre { get; set; }

        public string? TipoDocumento { get; set; }

        public string? Documento { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Departamento { get; set; }
        public string? Ciudad { get; set; }
        public string? Barrio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool Activo { get; set; }

    }
}
