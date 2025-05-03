using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models
{
    [Keyless]
    public class PagosPendientes
    {
        public string cliente { get; set; }
        public string sector { get; set; }
        public string enero { get; set; }
		public string febrero { get; set; }

		public string marzo { get; set; }



	}
}
