using BlazorApp2.Components.Pages;
using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;
using DocumentFormat.OpenXml.InkML;
using Microsoft.Data.SqlClient;


namespace BlazorApp2.Services
{

	
	public class TransaccProductoServices
	{
		private readonly ApplicationDbContext _context;

		public TransaccProductoServices(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> GuardarLista(List<TransaccionesProductos> trxProducto)
		{
			try
			{
				// _context.Entry(cliente).State = EntityState.Modified;
				await _context.TransaccionesProductos.AddRangeAsync(trxProducto); // Añade todos a la vez al contexto
				await _context.SaveChangesAsync(); // Guarda todos los cambios en una sola transacción			
				
				return true;
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		public async Task InsertUpdateTrxProducts(string tipoIngreso, Guid codigoEntradaSalida)
		{
			
			string sqlQuery = "EXEC INSERT_UPDATE_TRX_PRODUCTS @tipoIngreso, @codigoEntradaSalida";

		
			try
			{
				await _context.Database.ExecuteSqlRawAsync(
					sqlQuery,
					new SqlParameter("tipoIngreso", tipoIngreso), // Si usas PostgreSQL
					new SqlParameter("codigoEntradaSalida", codigoEntradaSalida) // Si usas SQL Server
				);

				
				Console.WriteLine($"Stored Procedure INSERT_UPDATE_TRX_PRODUCTS ejecutado con éxito para TipoIngreso: {tipoIngreso}, Codigo: {codigoEntradaSalida}");
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine($"Error al ejecutar Stored Procedure INSERT_UPDATE_TRX_PRODUCTS: {ex.Message}");
				throw; // Relanza la excepción para que el llamador pueda manejarla
			}
		}



	}
}
