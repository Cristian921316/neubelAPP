namespace BlazorApp2.Services
{
    using BlazorApp2.Components.Pages;
    using BlazorApp2.Data;
    using BlazorApp2.Models;
    using ClosedXML.Excel;
    using Microsoft.EntityFrameworkCore;
    using System.IO;
    public class PagoServices
    {
        private readonly ApplicationDbContext _context;

        public PagoServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PagoTrx>> getPagosAll()
        {
            return await _context.pagosTrx.ToListAsync();
        }
       

        public async Task<List<ViewerPagoTrx>> getPagosViewer(int idNegocio)
        {
            return await _context.viewerPagos.FromSqlRaw("EXEC VIEWER_PAGOSTRX @idNegocio = {0}", idNegocio).ToListAsync();
        }

        public async Task<bool> guardarPago(PagoTrx pago)
        {
            try
            {
                await _context.pagosTrx.AddAsync(pago);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes loguear el error si lo necesitas)
                Console.WriteLine($"Error al guardar el pago: {ex.Message}");
                return false;
            }
        }

        public async Task ExportarExcel(List<ViewerPagoTrx> pagos)
        {
            try
            {
               

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }



    }
}
