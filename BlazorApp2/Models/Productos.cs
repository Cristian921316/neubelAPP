using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{

    [Table("ADMINV_PRODUCTOS")]
    public class Productos
    {
        /* ADPRO_CODIGO
         ADBU_CODE
         ADPRO_CODALTERNO1
         ADPRO_DESCRIPCION
         ADPRO_CANTIDAD
         ADPRO_VALOR
         ADPRO_CODALTERNO2
         ADPRO_OBSERVACION
         ADPRO_USERUPDATE
         ADPRO_DATECREATED
         ADPRO_DATEUPDATE*/

        [Key]
        [Column("ADPRO_CODIGO")]
        public Guid adusb_codigo { get; set; }

        [Column("ADBU_CODE")]
        public int adbu_code { get; set; }

        [Column("ADPRO_CODALTERNO1")]
        public string? adpro_codigoalterno1 { get; set; }

        [Column("ADPRO_DESCRIPCION")]
        public string? adpro_descripcion { get; set; }

        [Column("ADPRO_CANTIDAD")]
        public int adpro_cantidad { get; set; }


        [Column("ADPRO_VALOR")]
        public decimal adpro_valor { get; set; }

        [Column("ADPRO_CODALTERNO2")]
        public string? adpro_codigoalterno2 { get; set; }

        [Column("ADPRO_OBSERVACION")]
        public string? adpro_observacion { get; set; }

        [Column("ADPRO_USERUPDATE")]
        public string adpro_userupdate { get; set; }

        [Column("ADPRO_DATECREATED")]
        public DateTime? adpro_datecreated { get; set; }

        [Column("ADPRO_DATEUPDATE")]
        public DateTime? adpro_dateupdate { get; set; }




    }
}
