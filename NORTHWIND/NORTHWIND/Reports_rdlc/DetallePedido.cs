using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace NORTHWIND.Reports_rdlc
{
    public partial class DetallePedido : Form
    {
        public DetallePedido()
        {
            InitializeComponent();
        }

        public int OrderId { get; set; }

        private void DetallePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.CustOrdersDetail' Puede moverla o quitarla según sea necesario.
            this.CustOrdersDetailTableAdapter.Fill(this.DataSet1.CustOrdersDetail, OrderId);

            ReportParameter[] reportParameter = new ReportParameter[1];
            reportParameter[0] = new ReportParameter("IdPedido", OrderId.ToString());
            reportViewer1.LocalReport.SetParameters(reportParameter);

            this.reportViewer1.RefreshReport();
        }
    }
}
