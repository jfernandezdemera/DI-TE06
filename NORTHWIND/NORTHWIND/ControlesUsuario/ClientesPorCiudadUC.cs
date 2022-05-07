using BusquedaDataGridViewCommon;
using ClientesProveedoresPorCiudad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NORTHWIND.ControlesUsuario
{
    public partial class ClientesPorCiudadUC : UserControl
    {
        public ClientesPorCiudadUC()
        {
            InitializeComponent();
            CargarDatos();
            CargarToolTip();
        }

        private void CargarToolTip()
        {
            this.tt_ClientesCiudad.SetToolTip(this.textBox_Search1, "Introduce un texto para buscar.");
            this.tt_ClientesCiudad.SetToolTip(this.button_Search1, "Pulsa para buscar el texto introducido.");
        }

        private void CargarDatos()
        {
            List<ClientesProveedoresPorCiudadVO> listado = NorthWind_BLL.NorthWind_BLL.RealizarConsultaClientesProveedoresPorCiuddad(true);
            if (listado.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView_Clientes_Ciudad.DataSource = listado;
            }
        }

        private void Button_Search1_Click(object sender, EventArgs e)
        {
            if (!textBox_Search1.Text.Equals(""))
                new BusquedaDataGridView(dataGridView_Clientes_Ciudad, textBox_Search1.Text);
        }
    }
}
