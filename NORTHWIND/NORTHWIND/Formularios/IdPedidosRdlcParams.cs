using IdPedido;
using NORTHWIND.Reports_rdlc;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NORTHWIND.Formularios
{
    public partial class IdPedidosRdlcParams : Form
    {
        private List<IdPedidoVO> idPedidos;
        public IdPedidosRdlcParams()
        {
            InitializeComponent();
            CargarDatosCombo();
        }

        private void CargarDatosCombo()
        {
            idPedidos = NorthWind_BLL.NorthWind_BLL.RealizarConsultaIdPedidos();

            if (idPedidos.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < idPedidos.Count; i++)
                {
                    comboBoxParams.Items.Add(idPedidos[i].IdPedido);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DetallePedido detallesPedidos = new DetallePedido
            {
                OrderId = idPedidos[comboBoxParams.SelectedIndex].IdPedido
            };

            detallesPedidos.Show();
            this.Close();
        }
    }
}
