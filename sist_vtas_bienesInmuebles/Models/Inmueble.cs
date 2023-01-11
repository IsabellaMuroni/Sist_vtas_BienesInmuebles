using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sist_vtas_bienesInmuebles.Models
{
    public class Inmueble
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Inmueble { get; set; }
      
        [ForeignKey("Tipo_Inmueble")]
        public int Id_tipo_inmueble { get; set; }
        public string Desc_inmueble { get; set; }
        public string Ubic_inmueble { get; set; }
        public double Costo_inmueble { get; set; }

    }
}
