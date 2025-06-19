using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Services
{
	public class ServiceDetalleCompra
	{

		private readonly ApplicationDbContext _context;

		public ServiceDetalleCompra(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<DetalleCompra>> GetDetalleComprasAsync(Guid cabeceraCompra)
		{

			try
			{
				return await _context.DetalleCompras.Where(c => c.adcom_codigo == cabeceraCompra).AsNoTracking().ToListAsync();

			}
			catch (Exception ex)
			{

				throw;
			}

		}

		public async Task<bool> guardarDetalleCompra(List<DetalleCompra> detalleCompra, bool guardarOK)
		{
			try
			{
				// _context.Entry(cliente).State = EntityState.Modified;
				if (guardarOK)
				{
					
					await _context.DetalleCompras.AddRangeAsync(detalleCompra); //guardar
				}
				else
				{
					
					_context.Entry(detalleCompra).State = EntityState.Modified; //modificar
				}
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				// Manejo de errores (puedes loguear el error si lo necesitas)
				Console.WriteLine($"Error al guardar el detalle compra: {ex.Message}");
				return false;
			}
		}




	}

}
