using EmpleadosMasVentas;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NORTHWIND.ControlesUsuario
{
    public partial class EmpleadosMasVentasUC : UserControl
    {
        public EmpleadosMasVentasUC()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<EmpleadosMasVentasVO> empleadosMasVentas = NorthWind_BLL.NorthWind_BLL.RealizarConsultaEmpleadosMasVentas();

            List<int> x1 = new List<int>(), y1 = new List<int>();

            for (int i = 0; i < empleadosMasVentas.Count; i++)
            {
                x1.Add(empleadosMasVentas[i].EmployeeID);
                y1.Add(empleadosMasVentas[i].CantidadVendidos);
            }

            EmpleadoVentasChart.Series["Ventas"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
        }
    }
}
