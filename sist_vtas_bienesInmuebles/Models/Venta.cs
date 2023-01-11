namespace sist_vtas_bienesInmuebles.Models
{
    public class Venta
    {
        public int Id_venta { get; set; }
        public int Id_inmueble { get; set; }
        public int Id_cliente { get; set; }
        public int Id_condicion { get; set; }
        public int Id_forma_pago { get; set; }
        public string Desc_venta { get; set; }
        public double Total_venta { get; set; }
        public double Total_iva { get; set; }
        public double Total_general { get; set; }
        public DateTime Fecha_venta { get; set; }
    }
}
