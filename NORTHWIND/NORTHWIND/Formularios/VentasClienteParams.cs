using DatosClientes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NORTHWIND.Reports_rdlc
{
    public partial class VentasClienteParams : Form
    {
        private List<DatosClientesVO> datosClientes;
        public VentasClienteParams()
        {
            InitializeComponent();
            CargarDatosCombo();
        }

        private void CargarDatosCombo()
        {
            datosClientes = NorthWind_BLL.NorthWind_BLL.RealizarConsultaDatosClientes();

            if (datosClientes.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < datosClientes.Count; i++)
                {
                    comboBoxParams.Items.Add(datosClientes[i].ContactName);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VentasCliente ventasCliente = new VentasCliente
            {
                CustomerId = datosClientes[comboBoxParams.SelectedIndex].CustomerId,
                CustomerName = datosClientes[comboBoxParams.SelectedIndex].ContactName
            };
            ventasCliente.Show();
            this.Close();
        }
    }
}
