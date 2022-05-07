using System;
using System.Windows.Forms;

namespace NORTHWIND.Reports_rdlc
{
    public partial class ProductosMasCaros : Form
    {
        public ProductosMasCaros()
        {
            InitializeComponent();
        }

        private void ProductosMasCaros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Ten_Most_Expensive_Products' Puede moverla o quitarla según sea necesario.
            this.Ten_Most_Expensive_ProductsTableAdapter.Fill(this.DataSet1.Ten_Most_Expensive_Products);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Ten_Most_Expensive_Products' Puede moverla o quitarla según sea necesario.
            this.Ten_Most_Expensive_ProductsTableAdapter.Fill(this.DataSet1.Ten_Most_Expensive_Products);

            this.reportViewer1.RefreshReport();
        }
    }
}
