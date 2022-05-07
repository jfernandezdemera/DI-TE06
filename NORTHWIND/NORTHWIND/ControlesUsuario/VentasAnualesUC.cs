using System.Collections.Generic;
using System.Windows.Forms;
using VentasAnuales;

namespace NORTHWIND.ControlesUsuario
{
    public partial class VentasAnualesUC : UserControl
    {
        public VentasAnualesUC()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<VentasAnualesVO> ventasAnualesList = NorthWind_BLL.NorthWind_BLL.RealizarConsultaVentasAno();

            if (ventasAnualesList.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<int> x1 = new List<int>();
                List<double> y1 = new List<double>();

                for (int i = 0; i < ventasAnualesList.Count; i++)
                {
                    x1.Add(ventasAnualesList[i].Anio);
                    y1.Add(ventasAnualesList[i].Suma);
                }

                chart_Ventas_Anuales.Series["Anios"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            }
        }
    }
}
