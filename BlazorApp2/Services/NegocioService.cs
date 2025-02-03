using BlazorApp2.Data;

using BlazorApp2.Components.Pages;
using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorApp2.Services
{
	public class NegocioService
	{
		private readonly ApplicationDbContext _context;

		public NegocioService(ApplicationDbContext context)
		{
			_context = context;
		}

		public int getIdByUser(string user)
		{

			try
			{
				return  _context.Negocios.FirstOrDefaultAsync(n => n.adbu_email == user).Result.adbu_code;
				 

			}
			catch (Exception ex)
			{

				return 0;
			}

		}


		public Task<Negocio> getByUser(string user)
		{

			try
			{
				return _context.Negocios.FirstOrDefaultAsync(n => n.adbu_email == user);


			}
			catch (Exception ex)
			{

				return null;
			}

		}


        public Negocio getByUserVoid(string user)
        {

            try
            {
                return _context.Negocios.FirstOrDefault(n => n.adbu_email == user);


            }
            catch (Exception ex)
            {

                return null;
            }

        }



    }
}
