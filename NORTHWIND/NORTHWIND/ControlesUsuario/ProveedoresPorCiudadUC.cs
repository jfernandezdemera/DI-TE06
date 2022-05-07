using BusquedaDataGridViewCommon;
using ClientesProveedoresPorCiudad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NORTHWIND.ControlesUsuario
{
    public partial class ProveedoresPorCiudadUC : UserControl
    {
        public ProveedoresPorCiudadUC()
        {
            InitializeComponent();
            CargarDatos();
            CargarToolTip();
        }

        private void CargarToolTip()
        {
            this.tt_ProveedoresCiudad.SetToolTip(this.textBox_Search, "Introduce un texto para buscar.");
            this.tt_ProveedoresCiudad.SetToolTip(this.button_Search, "Pulsa para buscar el texto introducido.");
        }

        private void CargarDatos()
        {
            List<ClientesProveedoresPorCiudadVO> listado = NorthWind_BLL.NorthWind_BLL.RealizarConsultaClientesProveedoresPorCiuddad(false);

            if (listado.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView_Proveedores_Ciudad.DataSource = listado;
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            if (!textBox_Search.Text.Equals(""))
                new BusquedaDataGridView(dataGridView_Proveedores_Ciudad, textBox_Search.Text);
        }
    }
}
