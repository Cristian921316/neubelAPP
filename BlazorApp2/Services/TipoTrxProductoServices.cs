using BlazorApp2.Components.Pages;
using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;
using DocumentFormat.OpenXml.InkML;

namespace BlazorApp2.Services
{
	public class TipoTrxProductoServices
	{
		private readonly ApplicationDbContext _context;

		public TipoTrxProductoServices(ApplicationDbContext context)
		{
			_context = context;
		}

		public List<TipoTrxProducto> getAllTipoTrx()
		{

			try
			{
				return _context.TipoTrxProductos.FromSql($"SELECT * FROM ADINV_TIPO_TRANSACC").ToList();


			}
			catch (Exception ex)
			{

				throw;
			}

		}


	}
}
