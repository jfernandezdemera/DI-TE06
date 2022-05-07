using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class VentasImporteReporte : Form
    {
        public VentasImporteReporte()
        {
            InitializeComponent();
            this.VentasImporte1.SetDatabaseLogon("di", "1234");
        }
    }
}
