namespace GyT.Data.Entity
{
    public class Venta : Entity
    {        
        public int IdProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public bool Promo { get; set; }
        public bool Pack { get; set; }
        public decimal PrecioActual { get; set; }
    }
}
