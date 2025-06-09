using BlazorApp2.Components.Pages;
using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;
using DocumentFormat.OpenXml.InkML;



namespace BlazorApp2.Services
{
	public class ProveedorServices
	{
		private readonly ApplicationDbContext _context;

		public ProveedorServices(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Proveedor>> getAllProveedorAsync()
		{

			try
			{
				return await _context.Proveedor.ToListAsync();


			}
			catch (Exception ex)
			{

				throw;
			}

		}


	}
}
