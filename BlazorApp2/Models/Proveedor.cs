using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
	/*ADPRV_CODIGO
	ADBU_CODE
	ADPRV_NOMBRE
	ADPRV_RUC
	ADPRV_TELEFONO
	ADPRO_CIUDAD
	ADPRV_DIRECCION
	ADPRV_EMAIL
	ADPRV_OBSERVACION
	ADPRV_USERUPDATE
	ADPRV_DATECREATED
	ADPRV_DATEUPDATE*/

	[Table("ADMINV_PROVEEDORES")]
	public class Proveedor
	{
		[Key]
		[Column("ADPRV_CODIGO")]
		public Guid adprv_codigo { get; set; }

		[Column("ADBU_CODE")]
		public int adbu_code { get; set; }

		[Column("ADPRV_NOMBRE")]
		public string adprv_nombre { get; set; }

		[Column("ADPRV_RUC")]
		public string adprv_ruc { get; set; }

		[Column("ADPRV_TELEFONO")]
		public string? adprv_telefono { get; set; }

		[Column("ADPRO_CIUDAD")]
		public string? adprv_ciudad { get; set; }

		[Column("ADPRV_DIRECCION")]
		public string? adprv_direccion { get; set; }

		[Column("ADPRV_EMAIL")]
		public string? adprv_email { get; set; }

		[Column("ADPRV_OBSERVACION")]
		public string? adprv_observacion { get; set; }

		[Column("ADPRV_USERUPDATE")]
		public string? adprv_userupdate { get; set; }

		[Column("ADPRV_DATECREATED")]
		public DateTime? adprv_datecreated { get; set; }

		[Column("ADPRV_DATEUPDATE")]
		public DateTime? adprv_dateupdate { get; set; }

	}
}
