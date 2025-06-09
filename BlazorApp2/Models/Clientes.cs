using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
	[Table("ADMPAY_CUSTOMER")]
	public class Clientes
	{

		// ADCU_NATIONALID ADCU_NAME   ADCU_PHONE ADCU_EMAIL  ADCU_DIRECTION ADCU_COORDINATES
		// ADCU_OBSERVATION ADUS_CODE   ADCU_DATECREATED ADCU_DATEUPDATE

		[Key]
		[Column("ADCU_CODE")]
		public int adcu_code { get; set; }
		[Column("ADBU_CODE")]
		public int adbu_code { get; set; }
		[Column("ADCU_NATIONALID")]
		public string? adcu_nationalid { get; set; }
		[Column("ADCU_NAME")]
		public string? adcu_name { get; set; }
		[Column("ADCU_PHONE")]
		public string? adcu_phone { get; set; }
		[Column("ADCU_EMAIL")]
		public string? adcu_email { get; set; }
		[Column("ADCU_DIRECTION")]
		public string? adcu_direction { get; set; }
		[Column("ADCU_COORDINATES")]
		public string? adcu_coordinates { get; set; }
		[Column("ADCU_OBSERVATION")]
		public string? adcu_observation { get; set; }
		[Column("ADUS_CODE")]
		public string? adus_code { get; set; }
		[Column("ADCU_DATECREATED")]
		public DateTime? adcu_datecreated { get; set; }
		[Column("ADCU_DATEUPDATE")]
		public DateTime? adcu_dateupdate { get; set; }

		[Column("ADCU_ESTADO")]
		public bool adcu_estado { get; set; }



	}

}
