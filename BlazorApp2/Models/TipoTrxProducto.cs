using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
	/*ADTR_CODIGO
ADTR_NOMBRE
ADTR_SIGNO
ADTR_OBSERVACION*/

	[Table("ADINV_TIPO_TRANSACC")]
	public class TipoTrxProducto
	{
		[Key]
		[Column("ADTR_CODIGO")]
		public Guid adtr_codigo { get; set; }

		[Column("ADTR_NOMBRE")]
		public string adtr_nombre { get; set; }

		[Column("ADTR_SIGNO")]
		public int adtr_signo { get; set; }

		[Column("ADTR_OBSERVACION")]
		public string? adtr_observacion { get; set; }

	}
}
