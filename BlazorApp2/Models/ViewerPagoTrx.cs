using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models
{
    [Keyless]
    public class ViewerPagoTrx
    {
        public string? clienteName {  get; set; }
        public string? sector { get; set; }
        public DateTime? trxDate { get; set; }
        public int? anio { get; set;}
        public string? periodo { get; set;}
        public string? comprobante { get; set;}
        public decimal? valor { get; set;}

    }
}
