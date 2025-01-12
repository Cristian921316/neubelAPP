namespace BlazorApp2.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ADMPAY_DATAILTRX")]
    public class PagoTrx
    {
        //ADAT_CODE ADBU_CODE   ADAT_TIPOPAGO ADCU_CODE
        //ADAT_COMPROBANTE ADAT_DESCRIPCION    ADUS_CODE ADAT_DATECREATED    ADAT_DATEUPDATE



        [Key]
        [Column("ADAT_CODE")]
        public int adat_codigo { get; set; }
        [Column("ADBU_CODE")]
        public int adbu_codigo { get; set; }

        [Column("ADAT_PERIODOPAGO")]
        public string? adat_periodopago { get; set; }

        [Column("ADAT_TIPOPAGO")]
        public string? adat_tipopago { get; set; }

        [Column("ADCU_CODE")]
        public int? adcu_code { get; set; }

        [Column("ADAT_COMPROBANTE")]
        public string? adat_comprobante { get; set; }

        [Column("ADAT_DESCRIPCION")]
        public string? adat_descripcion { get; set; }


        [Column("ADUS_CODE")]
        public string? adus_code { get; set; }

        [Column("ADAT_DATECREATED")]
        public DateTime? adat_datecreated { get; set; }

        [Column("ADAT_DATEUPDATE")]
        public DateTime? adat_dateupdate { get; set; }

        [Column("ADAT_VALOR")]
        public decimal? adat_valor {  get; set; }






    }
}
