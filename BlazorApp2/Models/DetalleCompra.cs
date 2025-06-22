using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
	/*ADTC_CODIGO
	ADCOM_CODIGO
	ADPRO_CODIGO
	ADTC_CANTIDAD
	ADTC_PRECIO_UNITARIO
	ADTC_PRECIO_TOTAL
	ADTC_IVA
	ADTC_ICE*/


	[Table("ADINV_DETALLE_COMPRA")]
	public class DetalleCompra
	{
		[Key]
		[Column("ADTC_CODIGO")]
		public Guid adtc_codigo { get; set; }

		[Column("ADCOM_CODIGO")]
		public Guid adcom_codigo { get; set; }

		[Column("ADPRO_CODIGO")]
		public Guid adpro_codigo { get; set; }

		[Column("ADPRO_NOMBRE")]
		public string adpro_nombre { get; set; }

		[Column("ADTC_CANTIDAD")]
		public decimal adtc_cantidad { get; set; }

		[Column("ADTC_PRECIO_UNITARIO")]
		public decimal adtc_precioUnitario { get; set; }

		[Column("ADTC_PRECIO_TOTAL")]
		public decimal adtc_precio_total { get; set; }

		[Column("ADTC_IVA")]
		public decimal adtc_iva { get; set; }

		[Column("ADTC_ICE")]
		public decimal? adtc_ice { get; set; }


	}
}
