using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class VentasPeriodoReporte : Form
    {
        public VentasPeriodoReporte()
        {
            InitializeComponent();
            this.VentasPeriodo1.SetDatabaseLogon("di", "1234");
        }
    }
}
