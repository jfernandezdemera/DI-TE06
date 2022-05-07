using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class EmpleadosVentasReporte : Form
    {
        public EmpleadosVentasReporte()
        {
            InitializeComponent();
            this.EmpleadosVentas1.SetDatabaseLogon("di", "1234");
        }
    }
}
