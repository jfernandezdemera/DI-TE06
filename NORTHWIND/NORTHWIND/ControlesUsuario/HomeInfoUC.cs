using NumeroClientes;
using NumeroEmpleados;
using NumeroProductos;
using NumeroProveedores;
using PromedioVentas;
using System.Windows.Forms;

namespace NORTHWIND.ControlesUsuario
{
    public partial class HomeInfoUC : UserControl
    {
        public HomeInfoUC()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            PromedioVentasVO promedioVentas = NorthWind_BLL.NorthWind_BLL.RealizarConsultaPromedioVentas();
            NumeroEmpleadosVO numeroEmpleados = NorthWind_BLL.NorthWind_BLL.RealizarConsultaNumeroEmpleados();
            NumeroProveedoresVO numeroProveedores = NorthWind_BLL.NorthWind_BLL.RealizarConsultaNumeroProveedores();
            NumeroClientesVO numeroClientes = NorthWind_BLL.NorthWind_BLL.RealizarConsultaNumeroClientes();
            NumeroProductosVO numeroProductos = NorthWind_BLL.NorthWind_BLL.RealizarConsultaNumeroProductos();

            if (promedioVentas == null || numeroEmpleados == null || numeroProveedores == null || numeroClientes == null || numeroProductos == null)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox_SumatorioVentas.Text = promedioVentas.Promedio.ToString() + "$";
                textBox_SumatorioEmpleados.Text = numeroEmpleados.NumeroEmpleados.ToString();
                textBox_SumatorioProveedores.Text = numeroProveedores.NumeroProveedores.ToString();
                textBox_SumatorioClientes.Text = numeroClientes.NumeroClientes.ToString();
                textBox_SumatorioProductos.Text = numeroProductos.NumeroProductos.ToString();
            }
        }

        private void Tlp_SumatorioEmpleados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
