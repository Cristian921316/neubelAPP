using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models.VIEWS
{
	[Keyless]
	public class ViewCompras
    {
        public Guid IdCompra { get; set; }
        public string? Factura { get; set; }

		public string Proveedor { get; set; }
		public string Comprador { get; set; }
        public string? Observacion { get; set; }

		public decimal Subtotal { get; set; }

		public decimal Iva { get; set; }
		public decimal Valor { get; set; }        

        public DateTime Registro { get; set; }

    }
}
