using BlazorApp2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<PagoTrx> pagosTrx { get; set; }

        public DbSet<ViewerPagoTrx> viewerPagos { get; set; }

       

    }
}
