using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sist_vtas_bienesInmuebles.Models
{
    public class Tipo_Inmueble
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_tipo_inmueble { get; set; }
        public string Desc_inmueble { get; set; }
    }
}
