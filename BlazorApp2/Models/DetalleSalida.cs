using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
	[Table("ADINV_DETALLE_SALIDA")]
	public class DetalleSalida
	{
		// ADTC_CODIGO (uniqueidentifier) - CLAVE PRIMARIA
		[Key] // Marca esta propiedad como la clave primaria
		[Column("ADTC_CODIGO")] // Mapea la propiedad al nombre de la columna en la BD
		public Guid AdtcCodigo { get; set; } // uniqueidentifier en SQL Server se mapea a Guid en C#

		// ADCSA_CODIGO (uniqueidentifier) - Clave foránea a ADINV_CABECERA_SALIDA.ADCSA_CODIGO (si aplica)
		// Nota: Asegúrate de que este mapeo sea correcto. Si ADCSA_CODIGO en la tabla de cabecera
		// es Guid como lo indicaste en la imagen, esta es la forma correcta.
		[Column("ADCSA_CODIGO")]
		public Guid AdcsaCodigo { get; set; }

		// ADPRO_CODIGO (uniqueidentifier) - Clave foránea a una tabla de productos (si aplica)
		[Column("ADPRO_CODIGO")]
		public Guid AdproCodigo { get; set; }

		// ADPRO_NOMBRE (varchar)
		[Column("ADPRO_NOMBRE")]
		[StringLength(255)] // Asumo una longitud común para varchar. AJUSTA ESTO a la longitud REAL de tu DB.
		public string AdproNombre { get; set; }

		// ADTC_CANTIDAD (decimal)
		[Column("ADTC_CANTIDAD", TypeName = "decimal(18,2)")] // Ajusta precisión/escala si es diferente en tu DB
		public decimal AdtcCantidad { get; set; }

		// ADTC_PRECIO_UNITARIO (decimal)
		[Column("ADTC_PRECIO_UNITARIO", TypeName = "decimal(18,2)")] // Ajusta precisión/escala
		public decimal AdtcPrecioUnitario { get; set; }

		// ADTC_PRECIO_TOTAL (decimal)
		[Column("ADTC_PRECIO_TOTAL", TypeName = "decimal(18,2)")] // Ajusta precisión/escala
		public decimal AdtcPrecioTotal { get; set; }

		// ADTC_IVA (decimal)
		[Column("ADTC_IVA", TypeName = "decimal(18,2)")] // Ajusta precisión/escala
		public decimal AdtcIva { get; set; }

		// ADTC_ICE (decimal)
		[Column("ADTC_ICE", TypeName = "decimal(18,2)")] // Ajusta precisión/escala
		public decimal AdtcIce { get; set; }

	}
}
