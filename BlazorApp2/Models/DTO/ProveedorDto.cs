using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models.DTO
{
    public class ProveedorDto
    {
        public Guid adprv_codigo { get; set; }
       
        public string adprv_nombre { get; set; }

    }
}
