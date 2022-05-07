using ProductosCaros;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NORTHWIND.ControlesUsuario
{
    public partial class ProductosOrdenadosUC : UserControl
    {
        public ProductosOrdenadosUC()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Lista productos caros
            List<ProductosCarosVO> productosCarosLista = NorthWind_BLL.NorthWind_BLL.RealizarConsultaProductos(true);

            if (productosCarosLista.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < productosCarosLista.Count; i++)
                {
                    Series serie = ProductosCarosChart.Series.Add(productosCarosLista[i].ProductName);
                    serie.Points.Add(productosCarosLista[i].UnitPrice);
                }
            }

            // Lista productos baratos
            List<ProductosCarosVO> productosBaratosLista = NorthWind_BLL.NorthWind_BLL.RealizarConsultaProductos(false);

            if (productosBaratosLista.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < productosBaratosLista.Count; i++)
                {
                    Series serie = ProductosBaratosChart.Series.Add(productosBaratosLista[i].ProductName);
                    serie.Points.Add(productosBaratosLista[i].UnitPrice);
                }
            }
        }
    }
}
