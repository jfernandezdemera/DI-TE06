using NORTHWIND.Reports_rdlc;
using System;
using System.Windows.Forms;

namespace NORTHWIND.Formularios
{
    public partial class DateParams : Form
    {
        public enum Estados
        {
            VENTASEMPLEADOSPOBLACION,
            VENTASPORANO
        }
        public DateParams()
        {
            InitializeComponent();
        }

        public int Estado { get; set; }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker_desde == null || dateTimePicker_hasta == null)
            {
                MessageBox.Show("REVISAR LAS FECHAS!!!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime desde = dateTimePicker_desde.Value.Date;
                DateTime hasta = dateTimePicker_hasta.Value.Date;
                switch (Estado)
                {
                    case (int)Estados.VENTASEMPLEADOSPOBLACION:
                        VentasEmpleadosPoblacion ventasEmpleadosPoblacion = new VentasEmpleadosPoblacion
                        {
                            FechaDesde = desde,
                            FechaHasta = hasta
                        };
                        this.Close();
                        ventasEmpleadosPoblacion.Show();
                        break;
                    case (int)Estados.VENTASPORANO:
                        VentasAno ventasAno = new VentasAno
                        {
                            FechaDesde = desde,
                            FechaHasta = hasta
                        };
                        this.Close();
                        ventasAno.Show();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
