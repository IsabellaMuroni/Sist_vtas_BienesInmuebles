using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sist_vtas_bienesInmuebles.Models
{
    public class Condicion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_condicion { get; set; }
        public string Desc_condicion { get; set; }
    }
}
