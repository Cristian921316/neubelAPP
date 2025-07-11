using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models
{

    [Keyless]
    public class ProductoFind
	{
		public Guid adpro_codigo { get; set; }
		public string adpro_descripcion { get; set; }

		public decimal adpro_cantidad { get; set; }	
	}
}
