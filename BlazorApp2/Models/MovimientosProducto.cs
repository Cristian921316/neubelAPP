using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models
{
    [Keyless]
    public class MovimientosProducto
	{

		public string tipoTrx { get; set; }
		public string codigo { get; set; }
		public string nombre { get; set; }
		public decimal cantidad { get; set; }

	}
}
