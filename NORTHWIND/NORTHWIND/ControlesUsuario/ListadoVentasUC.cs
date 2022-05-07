using BusquedaDataGridViewCommon;
using ListadoVentas;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NORTHWIND.ControlesUsuario
{
    public partial class ListadoVentasUC : UserControl
    {
        public ListadoVentasUC()
        {
            InitializeComponent();
            CargarDatos();
            CargarToolTip();
        }

        private void CargarToolTip()
        {
            this.tt_ListadoVentas.SetToolTip(this.textBox_Search, "Introduce un texto para buscar.");
            this.tt_ListadoVentas.SetToolTip(this.button_Search, "Pulsa para buscar el texto introducido.");
            this.tt_ListadoVentas.SetToolTip(this.textBox_Search2, "Introduce un texto para buscar.");
            this.tt_ListadoVentas.SetToolTip(this.button_Search2, "Pulsa para buscar el texto introducido.");
        }

        private void CargarDatos()
        {
            List<ListadoVentasVO> listado = NorthWind_BLL.NorthWind_BLL.RealizarConsultaListadoVentas();

            if (listado.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView_Listado_Ventas.DataSource = listado;
            }
        }

        private void DataGridView_Listado_Ventas_SelectionChanged(object sender, System.EventArgs e)
        {
            ListadoVentasVO ventasVO = (ListadoVentasVO)dataGridView_Listado_Ventas.CurrentRow.DataBoundItem;
            dataGridView_Detalle_Venta.DataSource = NorthWind_BLL.NorthWind_BLL.RealizarConsultaDetalleVenta(ventasVO.OrderID);
        }

        private void Button_Search2_Click(object sender, System.EventArgs e)
        {
            if (!textBox_Search2.Text.Equals(""))
                new BusquedaDataGridView(dataGridView_Detalle_Venta, textBox_Search2.Text);
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if(!textBox_Search.Text.Equals(""))
                new BusquedaDataGridView(dataGridView_Listado_Ventas, textBox_Search.Text);
        }
    }
}
