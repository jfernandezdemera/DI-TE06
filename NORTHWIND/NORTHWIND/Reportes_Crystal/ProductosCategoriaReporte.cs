using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class ProductosCategoriaReporte : Form
    {
        public ProductosCategoriaReporte()
        {
            InitializeComponent();
            this.ProductosCategoría1.SetDatabaseLogon("di", "1234");
        }
    }
}
