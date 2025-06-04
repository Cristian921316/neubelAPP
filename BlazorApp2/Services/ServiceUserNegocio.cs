using BlazorApp2.Components.Pages;
using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorApp2.Services
{
   


    public class ServiceUserNegocio
    {
        private readonly ApplicationDbContext _context;

        public ServiceUserNegocio(ApplicationDbContext context)
        {
            _context = context;
        }

        public int getIdNegocioByUser(string user)
        {

            try
            {
                return _context.UserBussines.FirstOrDefaultAsync(n => n.adusb_user == user).Result.adbu_code;


            }
            catch (Exception ex)
            {

                return 0;
            }

        }

		public async Task<List<UserBussines>> getUserNegocioLista(string user)
		{

			try
			{
                return await _context.UserBussines.ToListAsync();


			}
			catch (Exception ex)
			{

				throw;
			}

		}

	}
}
