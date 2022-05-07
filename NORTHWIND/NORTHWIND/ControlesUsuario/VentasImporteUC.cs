using BusquedaDataGridViewCommon;
using System.Collections.Generic;
using System.Windows.Forms;
using VentasOrdenadas;

namespace NORTHWIND.ControlesUsuario
{
    public partial class VentasImporteUC : UserControl
    {
        public VentasImporteUC()
        {
            InitializeComponent();
            CargarDatos();
            CargarToolTip();
        }

        private void CargarToolTip()
        {
            this.tt_VentasImporte.SetToolTip(this.textBox_Search, "Introduce un texto para buscar.");
            this.tt_VentasImporte.SetToolTip(this.button_Search, "Pulsa para buscar el texto introducido.");
            this.tt_VentasImporte.SetToolTip(this.textBox_Search2, "Introduce un texto para buscar.");
            this.tt_VentasImporte.SetToolTip(this.button_Search2, "Pulsa para buscar el texto introducido.");
        }
        private void CargarDatos()
        {
            List<VentasOrdenadasVO> listado = NorthWind_BLL.NorthWind_BLL.RealizarConsultaVentasOrdenadas(false);
            List<VentasOrdenadasVO> listado2 = NorthWind_BLL.NorthWind_BLL.RealizarConsultaVentasOrdenadas(true);

            if (listado.Count == 0 || listado2.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView_Listado_Ventas.DataSource = listado;
                dataGridView_Detalle_Venta.DataSource = listado2;
            }
        }

        private void Button_Search_Click(object sender, System.EventArgs e)
        {
            if (!textBox_Search.Text.Equals(""))
                new BusquedaDataGridView(dataGridView_Listado_Ventas, textBox_Search.Text);
        }

        private void Button_Search2_Click(object sender, System.EventArgs e)
        {
            if (!textBox_Search2.Text.Equals(""))
                new BusquedaDataGridView(dataGridView_Detalle_Venta, textBox_Search2.Text);
        }
    }
}
