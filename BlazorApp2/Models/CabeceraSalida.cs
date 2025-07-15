using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
	

	[Table("ADINV_CABECERA_SALIDA")]
	public class CabeceraSalida
	{
		
		
		[Key] 			 
		[Column("ADCSA_CODIGO")]
		public Guid AdcsaCodigo { get; set; } // uniqueidentifier en SQL Server se mapea a Guid en C#

		// ADCSA_GUIA (varchar) - CLAVE PRIMARIA	
		[Column("ADCSA_GUIA")] // Mapea la propiedad al nombre de la columna en la BD
		[StringLength(255)] // Asumo una longitud común para varchar si no se especifica. AJUSTA ESTO a la longitud REAL de tu DB.
		public string? AdcsaGuia { get; set; }

		[Column("ADTR_CODIGO")]
		public Guid AdtrCodigo { get; set; } // uniqueidentifier en SQL Server se mapea a Guid en C#

		// ADCSA_VENDEDOR (varchar)
		[Column("ADCSA_VENDEDOR")]
		[StringLength(255)] // Ajusta la longitud según tu base de datos
		public string AdcsaVendedor { get; set; }

		// ADCU_CODE (int)
		[Column("ADCU_CODE")]
		public int AdcuCode { get; set; }

		// ADCSA_FECHA_VENTA (date)
		[Column("ADCSA_FECHA_VENTA", TypeName = "date")] // Especifica el tipo de columna SQL "date"
		public DateTime AdcsaFechaVenta { get; set; }

		// ADCSA_SUBTOTAL (decimal)
		[Column("ADCSA_SUBTOTAL", TypeName = "decimal(18,2)")] // Ajusta la precisión y escala (18 dígitos en total, 2 decimales)
		public decimal AdcsaSubtotal { get; set; }

		// ADCSA_IVA (decimal)
		[Column("ADCSA_IVA", TypeName = "decimal(18,2)")] // Ajusta la precisión y escala
		public decimal AdcsaIva { get; set; }

		// ADCSA_TOTAL (decimal)
		[Column("ADCSA_TOTAL", TypeName = "decimal(18,2)")] // Ajusta la precisión y escala
		public decimal AdcsaTotal { get; set; }

		// ADCSA_VENDEDOR (varchar)
		[Column("ADCSA_OBSERVACION")]
		[StringLength(255)] // Ajusta la longitud según tu base de datos
		public string? Adcsa_observacion { get; set; }

		// ADCSA_USERUPDATE (nvarchar)
		[Column("ADCSA_USERUPDATE")]
		[StringLength(255)] // Ajusta la longitud según tu base de datos
		public string AdcsaUserUpdate { get; set; }

		// ADCSA_DATECREATED (datetime)
		[Column("ADCSA_DATECREATED")]
		public DateTime AdcsaDateCreated { get; set; }

		// ADCSA_DATEUPDATE (datetime) - Asumo que puede ser NULLable si no se especifica explícitamente
		// Si siempre tiene un valor, incluso por defecto, se puede usar DateTime sin '?'
		[Column("ADCSA_DATEUPDATE")]
		public DateTime? AdcsaDateUpdate { get; set; } // Se usa DateTime? si el campo es NULLable en la BD

		[Column("ADCSA_CODIGO_EQUIPO")]
		public string? adcsa_codigo_equipo { get; set; }

		[Column("ADCSA_DOCUMENTO")]
		public string? adcsa_documento { get; set; }



	}
}
