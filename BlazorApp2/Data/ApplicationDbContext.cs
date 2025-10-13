using BlazorApp2.Models;
using BlazorApp2.Models.VIEWS;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<PagoTrx> pagosTrx { get; set; }

        public DbSet<ViewerPagoTrx> viewerPagos { get; set; }

        public DbSet<PagosPendientes> pagosPendientes { get; set; }

        public DbSet<Negocio> Negocios { get; set; }

        public DbSet<UserBussines> UserBussines { get; set; }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<TransaccionesProductos> TransaccionesProductos { get; set; }

        public DbSet<Proveedor> Proveedor { get; set; }

        public DbSet<TipoTrxProducto> TipoTrxProductos { get; set; }

        public DbSet<CabeceraCompra> CabeceraCompras { get; set; }

		public DbSet<DetalleCompra> DetalleCompras { get; set; }

		public DbSet<CabeceraSalida> CabeceraSalidas { get; set; }

		public DbSet<DetalleSalida> DetalleSalidas { get; set; }

		public DbSet<MovimientosProducto> MovimientosProductos { get; set; }

        public DbSet<ViewCompras> viewCompras { get; set; }

		public DbSet<ProductoFind> productoFinds { get; set; }

        public DbSet<ViewSalida> viewSalida { get; set; }

		public DbSet<ViewSalidaDetallado> viewSalidaDetallado  { get; set; }


	}
}
