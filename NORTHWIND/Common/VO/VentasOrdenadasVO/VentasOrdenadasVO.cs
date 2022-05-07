namespace VentasOrdenadas
{
    public class VentasOrdenadasVO
    {
        private int orderId = int.MaxValue;
        private double extendedPrice = double.MaxValue;

        public VentasOrdenadasVO() { }
        public int OrderId { get => orderId; set => orderId = value; }
        public double ExtendedPrice { get => extendedPrice; set => extendedPrice = value; }

        static void Main() { }
    }
}
