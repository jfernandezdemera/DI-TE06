using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class VentasAnualesReporte : Form
    {
        public VentasAnualesReporte()
        {
            InitializeComponent();
            this.VentasAnuales1.SetDatabaseLogon("di", "1234");
        }
    }
}
