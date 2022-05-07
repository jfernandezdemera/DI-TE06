using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class ProveedoresCiudadReporte : Form
    {
        public ProveedoresCiudadReporte()
        {
            InitializeComponent();
            this.ProveedoresCiudad1.SetDatabaseLogon("di", "1234");
        }
    }
}
