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

		public async Task<List<Proveedor>> getAllProveedorAsync(int idNegocio)
		{

			try
			{
				return await _context.Proveedor.Where(p => p.adbu_code == idNegocio).AsNoTracking().Select(p => new  Proveedor
                {
                    // Aquí especificas los dos campos que quieres retornar
                    adprv_codigo = p.adprv_codigo, // Suponiendo que 'Nombre' es uno de los campos
                    adprv_nombre = p.adprv_nombre    // Suponiendo que 'RUC' es el otro campo
                })
                     .ToListAsync();


			}
			catch (Exception ex)
			{

				throw;
			}

		}

        public async Task<List<Proveedor>> getAllProveedorAsyncPage(int idNegocio)
        {

            try
            {
                return await _context.Proveedor.Where(p => p.adbu_code == idNegocio).OrderByDescending(p => p.adprv_datecreated).Take(10).ToListAsync();


            }
            catch (Exception ex)
            {

                throw;
            }

        }


        public async Task<Proveedor?> getById(Guid id)
        {
            try
            {
                return await _context.Proveedor.FirstOrDefaultAsync(p => p.adprv_codigo == id);
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes loguear el error si lo necesitas)
                Console.WriteLine($"Error al buscar el proveedor: {ex.Message}");
                return null;
            }

        }

        public async Task<bool> GuardarProveedor(Proveedor proveedor, bool guardarOK)
        {
            try
            {
                // _context.Entry(cliente).State = EntityState.Modified;
                if (guardarOK)
                {
                    proveedor.adprv_datecreated = DateTime.Now;
                    await _context.Proveedor.AddAsync(proveedor); //guardar
                }
                else
                {
                    proveedor.adprv_dateupdate = DateTime.Now;
                    _context.Entry(proveedor).State = EntityState.Modified; //modificar
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes loguear el error si lo necesitas)
                Console.WriteLine($"Error al guardar el proveedor: {ex.Message}");
                return false;
            }
        }


    }
}
