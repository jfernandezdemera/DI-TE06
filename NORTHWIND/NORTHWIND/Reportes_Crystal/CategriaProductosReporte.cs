using System.Windows.Forms;

namespace NORTHWIND.Reportes_Crystal
{
    public partial class CategriaProductosReporte : Form
    {
        public CategriaProductosReporte()
        {
            InitializeComponent();
            this.CategoriaProductos1.SetDatabaseLogon("di", "1234");
        }
    }
}
