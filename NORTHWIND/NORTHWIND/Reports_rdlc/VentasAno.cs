using System;
using System.Windows.Forms;

namespace NORTHWIND.Reports_rdlc
{
    public partial class VentasAno : Form
    {
        public VentasAno()
        {
            InitializeComponent();
        }

        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }

        private void VentasAno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Sales_by_Year' Puede moverla o quitarla según sea necesario.
            this.Sales_by_YearTableAdapter.Fill(this.DataSet1.Sales_by_Year, FechaDesde, FechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
