using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sist_vtas_bienesInmuebles.Models
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_venta { get; set; }
       
        [ForeignKey("Inmueble")]
        public int Id_inmueble { get; set; }

        [ForeignKey("Cliente")]
        public int Id_cliente { get; set; }

        [ForeignKey("Condicion")]
        public int Id_condicion { get; set; }

        [ForeignKey("Forma_Pago")]
        public int Id_forma_pago { get; set; }
        public string Desc_venta { get; set; }
        public double Total_venta { get; set; }
        public double Total_iva { get; set; }
        public double Total_general { get; set; }
        public DateTime Fecha_venta { get; set; }
    }
}
