using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
	[Table("ADMPAY_BUSINESS")]
	public class Negocio
	{
		//ADBU_CODE	ADBU_RUC	ADBU_NAME	ADBU_COMPANYNAME	ADBU_DIRECTION	ADBU_EMAIL	ADBU_PAGE	
		//ADBU_MANAGER	ADBU_USERUPDATE	ADBU_DATECREATED	ADBU_DATEUPDATE
		//

		[Key]
		[Column("ADBU_CODE")]
		public int adbu_code { get; set; }
		[Column("ADBU_RUC")]
		public string? adbu_ruc { get; set; }
		[Column("ADBU_NAME")]
		public string? adbu_name { get; set; }
		[Column("ADBU_COMPANYNAME")]
		public string? adbu_companyname { get; set; }
		[Column("ADBU_DIRECTION")]
		public string? adbu_direction { get; set; }
		[Column("ADBU_EMAIL")]
		public string? adbu_email { get; set; }
		[Column("ADBU_PAGE")]
		public string? adbu_page { get; set; }
		[Column("ADBU_MANAGER")]
		public string? adbu_manager { get; set; }
		[Column("ADBU_USERUPDATE")]
		public string? adbu_userupdate { get; set; }
		[Column("ADBU_DATECREATED")]
		public DateTime? adbu_datecreated { get; set; }
		[Column("ADBU_DATEUPDATE")]
		public DateTime? adbu_dateupdate { get; set; }

		[Column("ADBU_LOGO")]
		public string? adbu_logo { get; set; }
		


	}
}
