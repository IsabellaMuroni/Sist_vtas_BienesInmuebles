using Microsoft.EntityFrameworkCore;
using sist_vtas_bienesInmuebles.Models;

namespace sist_vtas_bienesInmuebles.Context
{
    public class InmuebleContext: DbContext
    {
        public InmuebleContext(DbContextOptions<InmuebleContext> options) : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Condicion> Condiciones { get; set;}
        public DbSet<Forma_Pago> Forma_Pago { get;set; }
        public DbSet<Inmueble> Inmuebles { get; set; }
        public DbSet<Tipo_Inmueble> Tipo_Inmuebles { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
