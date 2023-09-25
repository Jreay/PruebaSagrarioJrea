namespace PruebaSagrarioJrea.BD
{
    public class FacturaDetalle
    {
        public int idFacturaDetalle { get; set; }
        public int idFacturaCabecera { get; set; }
        public int idProducto { get; set; }
        public string cantidad { get; set; }
        public string total { get; set; }
    }
}
