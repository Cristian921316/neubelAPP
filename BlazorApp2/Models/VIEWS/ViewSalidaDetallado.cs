using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models.VIEWS
{
	//FechaVenta Guia    FechaRegistro Cliente CodSofadcom Descripcion Vendedor Observacion Cantidad Precio  Total
	[Keyless]
	public class ViewSalidaDetallado
	{
		public DateTime FechaVenta { get; set; }
		public string Guia { get; set; }
		public DateTime FechaRegistro { get; set; }
		public string Cliente { get; set; }
		public string CodSofadcom { get; set; }
		public string Descripcion { get; set; }
		public string Vendedor { get; set; }
		public string Observacion { get; set; }
		public decimal Cantidad { get; set; }
		public decimal Precio { get; set; }
		public decimal Total { get; set; }






	}
}
