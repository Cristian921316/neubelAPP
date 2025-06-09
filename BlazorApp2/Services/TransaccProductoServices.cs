using BlazorApp2.Components.Pages;
using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;
using DocumentFormat.OpenXml.InkML;


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
				// Manejo de errores (puedes loguear el error si lo necesitas)
				Console.WriteLine($"Error al guardar el producto: {ex.Message}");
				return false;
			}
		}



	}
}
