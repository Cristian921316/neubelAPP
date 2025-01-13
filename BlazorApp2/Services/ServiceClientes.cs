namespace BlazorApp2.Services
{
    using BlazorApp2.Components.Pages;
    using BlazorApp2.Data;
    using BlazorApp2.Models;
    using Microsoft.EntityFrameworkCore;
    public class ServiceClientes
    {
        private readonly ApplicationDbContext _context;

        public ServiceClientes(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Clientes>> GetClientesAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Clientes?> getById(int id)
        {
            try
            {
                return await _context.Clientes.FirstOrDefaultAsync(c => c.adcu_code == id);
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes loguear el error si lo necesitas)
                Console.WriteLine($"Error al buscar el cliente: {ex.Message}");
                return null;
            }

        }


        public async Task<bool> GuardarCliente(Clientes cliente)
        {
            try
            {
                await _context.Clientes.AddAsync(cliente);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes loguear el error si lo necesitas)
                Console.WriteLine($"Error al guardar el cliente: {ex.Message}");
                return false;
            }
        }        

    }
}
