using System;
using System.Windows.Forms;

namespace NORTHWIND.Reports_rdlc
{
    public partial class VentasEmpleadosPoblacion : Form
    {
        public VentasEmpleadosPoblacion()
        {
            InitializeComponent();
        }

        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }

        private void VentasEmpleadosPoblacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Employee_Sales_by_Country' Puede moverla o quitarla según sea necesario.
            this.Employee_Sales_by_CountryTableAdapter.Fill(this.DataSet1.Employee_Sales_by_Country, FechaDesde, FechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
