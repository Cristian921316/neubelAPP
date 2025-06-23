using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Services
{
	public class ServiceCabeceraSalida
	{
		private readonly ApplicationDbContext _context;

		public ServiceCabeceraSalida(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<CabeceraSalida>> getSalidas(int idNegocio)
		{

			try
			{
				return await _context.CabeceraSalidas.AsNoTracking().ToListAsync();

			}
			catch (Exception ex)
			{

				throw;
			}

		}

		public async Task<bool> saveCabeceraSalida(CabeceraSalida salida, bool guardarOK)
		{
			try
			{
				// _context.Entry(cliente).State = EntityState.Modified;
				if (guardarOK)
				{
					salida.AdcsaDateCreated = DateTime.Now;
					await _context.CabeceraSalidas.AddAsync(salida); //guardar
				}
				else
				{
					salida.AdcsaDateUpdate = DateTime.Now;
					_context.Entry(salida).State = EntityState.Modified; //modificar
				}
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				// Manejo de errores (puedes loguear el error si lo necesitas)
				Console.WriteLine($"Error al guardar el cabecera salida: {ex.Message}");
				return false;
			}
		}


	}
}
