using System;
using System.Windows.Forms;

namespace NORTHWIND.Reports_rdlc
{
    public partial class VentasCategoria : Form
    {
        public VentasCategoria()
        {
            InitializeComponent();
        }

        public string Anio { get; set; }
        public string Categoria { get; set; }

        private void VentasCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SalesByCategory' Puede moverla o quitarla según sea necesario.
            this.SalesByCategoryTableAdapter.Fill(this.DataSet1.SalesByCategory, Categoria, Anio);

            this.reportViewer1.RefreshReport();
        }
    }
}
