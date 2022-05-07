using NORTHWIND.Reportes;
using NORTHWIND.Reportes_Crystal;
using System;
using System.Windows.Forms;

namespace NORTHWIND.Formularios
{
    public partial class ProductosCategoríaParams : Form
    {
        public ProductosCategoríaParams()
        {
            InitializeComponent();
            CargarCombo();
        }

        public void CargarCombo()
        {
            comboBox_categoria.Items.Add("PRODUCTOS POR GATEGORÍAS");
            comboBox_categoria.Items.Add("CATEGORÍAS DE PRODUCTOS");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int seleccion = comboBox_categoria.SelectedIndex;
            switch (seleccion)
            {
                case 0:
                    ProductosCategoriaReporte productosCategoriaReporte = new ProductosCategoriaReporte();
                    productosCategoriaReporte.Show();
                    this.Close();
                    break;
                case 1:
                    CategriaProductosReporte categriaProductosReporte = new CategriaProductosReporte();
                    categriaProductosReporte.Show();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("REVISA LA SELECCIÓN!!!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
