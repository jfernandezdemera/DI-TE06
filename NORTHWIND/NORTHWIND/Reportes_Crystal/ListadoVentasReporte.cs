using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class ListadoVentasReporte : Form
    {
        public ListadoVentasReporte()
        {
            InitializeComponent();
            this.ListadoVentas1.SetDatabaseLogon("di", "1234");
        }
    }
}
