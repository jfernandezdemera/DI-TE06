namespace ProductosCaros
{
    public class ProductosCarosVO
    {
        private string productName = string.Empty;
        private double unitPrice = double.MaxValue;

        public string ProductName { get => productName; set => productName = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }

        public ProductosCarosVO() { }

        static void Main() { }
    }
}
