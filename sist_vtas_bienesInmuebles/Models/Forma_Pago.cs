using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sist_vtas_bienesInmuebles.Models
{
    public class Forma_Pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_forma_pago { get; set; }
        public string Desc_forma_pago { get; set; }

    }
}
