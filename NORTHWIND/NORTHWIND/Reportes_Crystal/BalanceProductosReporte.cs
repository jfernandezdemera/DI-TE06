using System.Windows.Forms;

namespace NORTHWIND.Reportes
{
    public partial class BalanceProductosReporte : Form
    {
        public BalanceProductosReporte()
        {
            InitializeComponent();
            this.BalanceProductosBaratos1.SetDatabaseLogon("di", "1234");
        }
    }
}
