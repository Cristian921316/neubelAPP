using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models.VIEWS
{

    [Keyless]
    public class ViewSalida
    {

        public Guid IdCompra {  get; set; }
        public DateTime FechaVenta { get; set; }

        public string Guia { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string Cliente { get; set; }

        public string Observacion { get; set; }

        public decimal Subtotal { get; set; }

        public decimal Iva {  get; set; }

        public decimal Total { get; set; }



    }
}
