using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{

	/*ADKPR_CODIGO,ADBU_CODE,ADTR_CODIGO,ADPRV_CODIGO,ADKPR_FECHA,ADKPR_FACTURA,ADKPR_COMPRADOR,ADKPR_OBSERVACION,ADPRO_CODIGO,ADKPR_CANTIDAD
ADKPR_PRECIO_UNITARIO,ADKPR_PRECIO_IVA,ADKPR_PRECIO_TOTAL,ADKPR_USERUPDATE,ADKPR_DATECREATED,ADKPR_DATEUPDATE*/


	[Table("ADINV_TRANSACC_KARDEX")]
	public class TransaccionesProductos
	{
		[Key]
		[Column("ADKPR_CODIGO")]
		public Guid adkpr_codigo { get; set;}

		[Column("ADBU_CODE")]
		public int adbu_code { get; set; }
		

		[Column("ADPRV_CODIGO")]
		public Guid? adprv_codigo { get; set; }

		[Column("ADCU_CODE")]
		public int? adcu_code { get; set; }

		[Column("ADKPR_FECHA")]
		public DateTime adkpr_fecha { get; set; }

		[Column("ADKPR_FACTURA")]
		public string adkpr_factura { get; set; }

		[Column("ADKPR_COMPRADOR")]
		public string adkpr_comprador { get; set; }

		[Column("ADKPR_OBSERVACION")]
		public string adkpr_observacion { get; set; }

		[Column("ADTR_CODIGO")]
		public Guid adtr_codigo { get; set; }

		[Column("ADPRO_CODIGO")]
		public Guid adpro_codigo { get; set; }

		[Column("ADPRO_NOMBRE_PRODUCTO")]
		public string adpro_nombre_producto { get; set; }

		[Column("ADKPR_CANTIDAD")]
		public int adkpr_cantidad { get; set; }

		[Column("ADKPR_PRECIO_UNITARIO")]
		public decimal adkpr_precio_unitario { get; set; }

		[Column("ADKPR_PRECIO_IVA")]
		public decimal adkpr_precio_iva { get; set; }

		[Column("ADKPR_PRECIO_TOTAL")]
		public decimal adkpr_precio_total { get; set; }

		[Column("ADKPR_USERUPDATE")]
		public string adkpr_userupdate { get; set; }

		[Column("ADKPR_DATECREATED")]
		public DateTime adkpr_datecreated { get; set; }

		[Column("ADKPR_DATEUPDATE")]
		public DateTime? adkpr_dateupdate { get; set; }

	}
}
