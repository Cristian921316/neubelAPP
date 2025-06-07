using BlazorApp2.Components.Pages;
using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;


namespace BlazorApp2.Services
{
    public class ProductoServices
    {
        private readonly ApplicationDbContext _context;

        public ProductoServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Productos>> getAllProductosAsync()
        {

            try
            {
                return await _context.Productos.ToListAsync();


            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<Productos?> getById(Guid id)
        {
            try
            {
                return await _context.Productos.FirstOrDefaultAsync(p => p.adpro_codigo == id);
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes loguear el error si lo necesitas)
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return null;
            }

        }

        public async Task<bool> Guardar(Productos producto, bool guardarOK)
        {
            try
            {
                // _context.Entry(cliente).State = EntityState.Modified;
                if (guardarOK)
                {
                    producto.adpro_datecreated = DateTime.Now;
                    await _context.Productos.AddAsync(producto); //guardar
                }
                else
                {
                    producto.adpro_dateupdate = DateTime.Now;
                    _context.Entry(producto).State = EntityState.Modified; //modificar
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes loguear el error si lo necesitas)
                Console.WriteLine($"Error al guardar el producto: {ex.Message}");
                return false;
            }
        }

        public async Task Eliminar(Guid productoId)
        {
            // Busca el producto por su ID
            var productoAEliminar = await _context.Productos.FindAsync(productoId); // Asumo que tu DbSet se llama Productos

            if (productoAEliminar != null)
            {
                _context.Productos.Remove(productoAEliminar); // Marca el producto para eliminación
                await _context.SaveChangesAsync(); // Guarda los cambios en la base de datos
            }
            else
            {
                // Opcional: Lanza una excepción o registra un mensaje si el producto no se encontró
                throw new KeyNotFoundException($"Producto con ID {productoId} no encontrado.");
            }
        }


    }
}
