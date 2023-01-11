using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sist_vtas_bienesInmuebles.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//para que sea autoincremental
        public int Id_cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Dir_cliente { get; set; }
        public string Correo_cliente { get; set; }
        public int Telefono_cliente { get; set; }


    }
}
