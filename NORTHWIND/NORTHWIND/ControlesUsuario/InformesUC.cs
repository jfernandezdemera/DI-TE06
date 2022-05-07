using NORTHWIND.Formularios;
using NORTHWIND.Reports_rdlc;
using System;
using System.Windows.Forms;
using static NORTHWIND.Formularios.DateParams;

namespace NORTHWIND.ControlesUsuario
{
    public partial class InformesUC : UserControl
    {
        public InformesUC()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VentasClienteParams listadoVetasRdlcParams = new VentasClienteParams();
            listadoVetasRdlcParams.Show();
        }

        private void Button_DetallesPedidos_Click(object sender, EventArgs e)
        {
            IdPedidosRdlcParams idPedidosRdlcParams = new IdPedidosRdlcParams();
            idPedidosRdlcParams.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateParams ventasEmpleadosPoblacionParams = new DateParams
            {
                Estado = (int)Estados.VENTASEMPLEADOSPOBLACION
            };
            ventasEmpleadosPoblacionParams.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DateParams ventasAno = new DateParams
            {
                Estado = (int)Estados.VENTASPORANO
            };
            ventasAno.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            VentasCategoriaParams ventasCategoriaParams = new VentasCategoriaParams();
            ventasCategoriaParams.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ProductosMasCaros productosCaros = new ProductosMasCaros();
            productosCaros.Show();
        }

        private void Button5_Click_2(object sender, EventArgs e)
        {
            VentasCliente ventasCliente = new VentasCliente();
            ventasCliente.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ProductosMasCaros productosMasCaros = new ProductosMasCaros();
            productosMasCaros.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            VentasCategoriaParams ventasCategoriaParams = new VentasCategoriaParams();
            ventasCategoriaParams.Show();
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            DateParams dateParams = new DateParams
            {
                Estado = (int)Estados.VENTASEMPLEADOSPOBLACION
            };
            dateParams.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            VentasClienteParams ventasClienteParams = new VentasClienteParams();
            ventasClienteParams.Show();
        }
    }
}
