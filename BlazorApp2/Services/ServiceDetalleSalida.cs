using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Services
{
	public class ServiceDetalleSalida
	{
		private readonly ApplicationDbContext _context;

		public ServiceDetalleSalida(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<DetalleSalida>> GetDetalleSalidasAsync(Guid cabeceraSalida)
		{

			try
			{
				return await _context.DetalleSalidas.Where(c => c.AdcsaCodigo == cabeceraSalida).ToListAsync();

			}
			catch (Exception ex)
			{

				throw;
			}

		}

		public async Task<bool> saveDetalleSalida(List<DetalleSalida> detalleSalida, bool guardarOK)
		{
			try
			{
				// _context.Entry(cliente).State = EntityState.Modified;
				if (guardarOK)
				{

					await _context.DetalleSalidas.AddRangeAsync(detalleSalida); //guardar
				}
				else
				{

					_context.Entry(detalleSalida).State = EntityState.Modified; //modificar
				}
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				// Manejo de errores (puedes loguear el error si lo necesitas)
				Console.WriteLine($"Error al guardar el detalle salida: {ex.Message}");
				return false;
			}
		}


	}
}
