namespace GyT.Data.Entity
{
    public class Producto : Entity
    {
        public string Nombre { get; set; }
        public string IdTipoProducto { get; set; }
        public decimal Costo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioVentaPack { get; set; }
    }
}
