using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
	/*ADCOM_CODIGO
ADBU_CODE
ADTR_CODIGO
ADCOM_FACTURA
ADCOM_COMPRADOR
ADPRV_CODIGO
ADCOM_EMISION
ADCOM_ESTADO
ADCOM_USERUPDATE
ADCOM_DATECREATED
ADCOM_DATEUPDATE*/

	[Table("ADMINV_CABECERA_COMPRA")]
	public class CabeceraCompra
	{
		[Key]
		[Column("ADCOM_CODIGO")]
		public Guid adcom_codigo { get; set; }

		[Column("ADBU_CODE")]
		public int adbu_code { get; set; }

		[Column("ADCOM_COMPRADOR")]
		public string adcom_comprador { get; set; }

		[Column("ADTR_CODIGO")]
		public Guid adtr_codigo { get; set; }

		[Column("ADPRV_CODIGO")]
		public Guid adprv_codigo { get; set; }

		[Column("ADCOM_FACTURA")]
		public string? adcom_factura { get; set; }

		[Column("ADCOM_EMISION")]
		public DateTime? adcom_emision { get; set; }

		[Column("ADCOM_OBSERVACION")]
		public string? adcom_observacion { get; set; }

		[Column("ADCOM_ESTADO")]
		public int? adcom_estado { get; set; }

		[Column("ADCOM_USERUPDATE")]
		public string? adcom_userUpdate { get; set; }

		[Column("ADCOM_DATECREATED")]
		public DateTime? adcom_dateCreated { get; set; }

		[Column("ADCOM_DATEUPDATE")]
		public DateTime? adcom_dateupdate { get; set; }

	}
}
