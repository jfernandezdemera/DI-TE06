using EmpleadosVentasPeriodo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NORTHWIND.ControlesUsuario
{
    public partial class EmpleadosMasVentasPeriodoUC : UserControl
    {
        public EmpleadosMasVentasPeriodoUC()
        {
            InitializeComponent();
            CargarToolTip();
        }

        private void CargarToolTip()
        {
            tt_EmpleadosMasVentas.SetToolTip(this.buttonAccion, "Pulsa para consultar datos entre las fechas introducidas.");
            tt_EmpleadosMasVentas.SetToolTip(this.dateTimePicker1, "Selecciona la fecha inicical.");
            tt_EmpleadosMasVentas.SetToolTip(this.dateTimePicker2, "Selecciona la fecha final.");
        }

        private void CargarDatos(DateTime fechaDesde, DateTime fechasta)
        {
            List<EmpleadosVentasPeriodoVO> empleadosMasVentas = NorthWind_BLL.NorthWind_BLL.RealizarConsultaEmpleadosVentasPeriodo(fechaDesde, fechasta);

            List<int> x1 = new List<int>(), y1 = new List<int>();

            for (int i = 0; i < empleadosMasVentas.Count; i++)
            {
                x1.Add(empleadosMasVentas[i].EmployeeID);
                y1.Add(empleadosMasVentas[i].CantidadPedidos);
            }

            EmpleadoVentasPeriodoChart.Series["Ventas"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
        }

        private void ButtonAccion_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde, fechasta;
            fechaDesde = dateTimePicker1.Value.Date;
            fechasta = dateTimePicker2.Value.Date;
            CargarDatos(fechaDesde, fechasta);
        }
    }
}
