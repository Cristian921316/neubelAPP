using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Services
{
	public class ServiceCabeceraCompra
	{
		private readonly ApplicationDbContext _context;

		public ServiceCabeceraCompra(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<CabeceraCompra>> GetCabeceraComprasAsync(int idNegocio)
		{

			try
			{
				return await _context.CabeceraCompras.Where(c => c.adbu_code == idNegocio).AsNoTracking().ToListAsync();

			}
			catch (Exception ex)
			{

				throw;
			}

		}

		public async Task<bool> guardarCabeceraCompra(CabeceraCompra compra, bool guardarOK)
		{
			try
			{
				// _context.Entry(cliente).State = EntityState.Modified;
				if (guardarOK)
				{
					compra.adcom_dateCreated = DateTime.Now;
					await _context.CabeceraCompras.AddAsync(compra); //guardar
				}
				else
				{
					compra.adcom_dateupdate = DateTime.Now;
					_context.Entry(compra).State = EntityState.Modified; //modificar
				}
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				// Manejo de errores (puedes loguear el error si lo necesitas)
				Console.WriteLine($"Error al guardar el cabecera compra: {ex.Message}");
				return false;
			}
		}


	}
}
