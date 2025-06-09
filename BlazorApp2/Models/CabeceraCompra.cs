using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
	/*ADCOM_CODIGO
	ADBU_CODE
	ADCOM_NUMERO_REGISTRO
	ADCOM_TIPOCOMPRA
	ADPRV_CODIGO
	ADCOM_FACTURA
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

		[Column("ADCOM_NUMERO_REGISTRO")]
		public string adcom_numeroRegistro { get; set; }

		[Column("ADCOM_TIPOCOMPRA")]
		public string adcom_tipoCompra { get; set; }

		[Column("ADPRV_CODIGO")]
		public string adprv_codigo { get; set; }

		[Column("ADCOM_FACTURA")]
		public string? adcom_factura { get; set; }

		[Column("ADCOM_EMISION")]
		public string? adcom_emision { get; set; }

		[Column("ADCOM_ESTADO")]
		public string? adcom_estado { get; set; }

		[Column("ADCOM_USERUPDATE")]
		public string adcom_userUpdate { get; set; }

		[Column("ADCOM_DATECREATED")]
		public DateTime? adcom_dateCreated { get; set; }

		[Column("ADCOM_DATEUPDATE")]
		public DateTime? adcom_dateupdate { get; set; }

	}
}
