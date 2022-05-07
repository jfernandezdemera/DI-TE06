namespace CategoriasExistentes
{
    public class CategoriasExistentesVO
    {
        private string categoryName = string.Empty;
        private int categoryID = int.MaxValue;

        public string CategoryName { get => categoryName; set => categoryName = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }

        static void Main() { }
    }
}
