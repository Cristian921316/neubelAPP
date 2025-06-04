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

    }
}
