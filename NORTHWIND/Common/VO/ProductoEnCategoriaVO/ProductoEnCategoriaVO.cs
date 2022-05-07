namespace ProductoEnCategoria
{
    public class ProductoEnCategoriaVO
    {
        private int productID = int.MaxValue, SupplierID = int.MaxValue, unitsInStock = int.MaxValue, unitsOnOrder = int.MaxValue;
        private double unitPrice = double.MaxValue;
        private string productName = string.Empty, quantityPerUnit = string.Empty;

        public int ProductID { get => productID; set => productID = value; }
        public int SupplierID1 { get => SupplierID; set => SupplierID = value; }
        public int UnitsInStock { get => unitsInStock; set => unitsInStock = value; }
        public int UnitsOnOrder { get => unitsOnOrder; set => unitsOnOrder = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string QuantityPerUnit { get => quantityPerUnit; set => quantityPerUnit = value; }

        static void Main() { }
    }
}
