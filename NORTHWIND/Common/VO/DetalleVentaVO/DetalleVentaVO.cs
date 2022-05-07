namespace DetalleVenta
{
    public class DetalleVentaVO
    {
        private int productID = int.MaxValue, quantity = int.MaxValue, discount = int.MaxValue;
        private double unitPrice = double.MaxValue, extendedPrice = double.MaxValue;
        private string productName = string.Empty;

        public DetalleVentaVO() { }

        public int ProductID { get => productID; set => productID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Discount { get => discount; set => discount = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public double ExtendedPrice { get => extendedPrice; set => extendedPrice = value; }
        public string ProductName { get => productName; set => productName = value; }

        static void Main() { }
    }
}
