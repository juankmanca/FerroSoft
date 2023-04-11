using FerreSoft.API.Data;
using FerreSoft.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await ValidarUsuarios();
        }

        private async Task ValidarUsuarios()
        {
            if (!_context.Usuario.Any())
            {
                _context.Usuario.Add(new Usuario { Nombre = "Juan" , Activo = true, Barrio = "Prado Centro" , Ciudad = "Medellín", Correo = "juank@gmail.com", Departamento = "Antioquia", Direccion = "Carrera 80 #12-42", Documento = "100722201421", FechaActualizacion = DateTime.UtcNow, FechaCreacion = DateTime.UtcNow, Telefono = "3202303223", TipoDocumento = "Cedula" });
            }

            await _context.SaveChangesAsync();
        }
    }
}
