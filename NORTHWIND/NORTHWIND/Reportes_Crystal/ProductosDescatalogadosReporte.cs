using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class ProductosDescatalogadosReporte : Form
    {
        public ProductosDescatalogadosReporte()
        {
            InitializeComponent();
            this.ProductosDescatalogados1.SetDatabaseLogon("di", "1234");
        }
    }
}
