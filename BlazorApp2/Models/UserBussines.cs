using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
    [Table("ADMUS_USERBUSSINESS")]
    public class UserBussines
    {
        [Key]
        [Column("ADUSB_CODIGO")]
        public Guid adusb_codigo { get; set; }

        [Column("ADBU_CODE")]
        public int adbu_code { get; set; }

        [Column("ADUSB_USER")]
        public string adusb_user { get; set; }

        [Column("ADUSB_DESCRIPCION")]
        public string adusb_descripcion { get; set; }

        [Column("ADUSB_USERUPDATE")]
        public string adusb_userupdate { get; set; }

        [Column("ADUSB_DATECREATED")]
        public DateTime adusb_datecreated { get; set; }

        [Column("ADUSB_DATEUPDATE")]
        public DateTime? adusb_dateupdate { get; set; }

    }
}
