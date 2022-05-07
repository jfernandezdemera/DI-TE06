using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class ProductosActualesReporte : Form
    {
        public ProductosActualesReporte()
        {
            InitializeComponent();
            this.ProductosActuales1.SetDatabaseLogon("di", "1234");
        }
    }
}
