using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ParkingMartiAPP.Clases;

namespace ParkingMartiAPP.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Camiones>Camiones { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<LineasFactura> LineasFactura { get; set; }
        public DbSet<LineasProforma> LineasProforma { get; set; }
        public DbSet<Plazas> Plazas { get; set; }
        public DbSet<Proformas> Proformas { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Trabajadores> Trabajadores { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }

    }
}
