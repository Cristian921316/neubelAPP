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

        public async Task<List<Clientes>> GetClientesAsync(int idNegocio)
        {
			return await _context.Clientes.Where(c=> c.adbu_code == idNegocio).ToListAsync();			

		}

        public async Task<List<Clientes>> GetClientesActivosAsync(int idNegocio)
        {
            return await _context.Clientes.Where(c => c.adbu_code == idNegocio && c.adcu_estado).ToListAsync();

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


        public async Task<bool> GuardarCliente(Clientes cliente, bool guardarOK)
        {
            try
            {
                // _context.Entry(cliente).State = EntityState.Modified;
                if (guardarOK)
                {
                    cliente.adcu_datecreated = DateTime.Now;
                    await _context.Clientes.AddAsync(cliente); //guardar
                }
                else
                {
                    cliente.adcu_dateupdate = DateTime.Now;
                    _context.Entry(cliente).State = EntityState.Modified; //modificar
                }
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
