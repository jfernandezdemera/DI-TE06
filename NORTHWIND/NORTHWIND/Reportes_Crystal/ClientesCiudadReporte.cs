using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class ClientesCiudadReporte : Form
    {
        public ClientesCiudadReporte()
        {
            InitializeComponent();
            this.ClientesCiudad1.SetDatabaseLogon("di", "1234");
        }
    }
}
