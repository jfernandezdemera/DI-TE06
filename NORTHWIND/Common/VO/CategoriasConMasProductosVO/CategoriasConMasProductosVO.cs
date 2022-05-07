namespace CategoriasConMasProductos
{
    public class CategoriasConMasProductosVO
    {
        private string categoryName = string.Empty;
        private int cantidad = int.MaxValue;

        public string CategoryName { get => categoryName; set => categoryName = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        static void Main() { }
    }
}
