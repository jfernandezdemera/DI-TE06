using BusquedaDataGridViewCommon;
using GamaProductos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NORTHWIND.ControlesUsuario
{
    public partial class GamaProductosUC : UserControl
    {
        public GamaProductosUC()
        {
            InitializeComponent();
            CargarDatos();
            CargarToolTip();
        }

        private void CargarToolTip()
        {
            this.tt_GamaProductos.SetToolTip(this.textBox_Search1, "Escribe el texto a buscar.");
            this.tt_GamaProductos.SetToolTip(this.textBox_Search2, "Escribe el texto a buscar.");
            this.tt_GamaProductos.SetToolTip(this.button_Search1, "Pulsa para buscar el texto introducido.");
            this.tt_GamaProductos.SetToolTip(this.button_Search2, "Pulsa para buscar el texto introducido.");
        }

        private void CargarDatos()
        {
            List<GamaProductosVO> gamaProductos = NorthWind_BLL.NorthWind_BLL.RealizarConsultaGamaProductos(false);
            List<GamaProductosVO> gamaProductos1 = NorthWind_BLL.NorthWind_BLL.RealizarConsultaGamaProductos(true);
            if (gamaProductos.Count == 0 || gamaProductos1.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView_Listado_Actuales.DataSource = gamaProductos;
                dataGridView_Listado_Descatalogados.DataSource = gamaProductos1;
            }
        }

        private void Button_Search1_Click(object sender, EventArgs e)
        {
            if (!textBox_Search1.Text.Equals(""))
                new BusquedaDataGridView(dataGridView_Listado_Actuales, textBox_Search1.Text);
        }

        private void Button_Search2_Click(object sender, EventArgs e)
        {
            if (!textBox_Search2.Text.Equals(""))
                new BusquedaDataGridView(dataGridView_Listado_Descatalogados, textBox_Search2.Text);
        }
    }
}
