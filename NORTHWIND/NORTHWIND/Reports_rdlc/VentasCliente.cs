using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace NORTHWIND.Reports_rdlc
{
    public partial class VentasCliente : Form
    {
        public VentasCliente()
        {
            InitializeComponent();
        }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }

        private void ListadoVentasRdlc_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.CustOrderHist' Puede moverla o quitarla según sea necesario.
            this.CustOrderHistTableAdapter.Fill(this.DataSet1.CustOrderHist, CustomerId);
            ReportParameter p = new ReportParameter("nombreCliente", CustomerName);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
