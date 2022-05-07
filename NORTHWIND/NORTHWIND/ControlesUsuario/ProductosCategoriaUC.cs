using CategoriasConMasProductos;
using CategoriasExistentes;
using ProductoEnCategoria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NORTHWIND.ControlesUsuario
{
    public partial class ProductosCategoriaUC : UserControl
    {
        public ProductosCategoriaUC()
        {
            InitializeComponent();
            CargarDatosCombo();
            CargarDatosCharPastel();
        }

        private void CargarDatosCombo()
        {
            List<CategoriasExistentesVO> categoriasExistentes = NorthWind_BLL.NorthWind_BLL.RealizarConsultaCategoriasExistentes();

            if (categoriasExistentes.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < categoriasExistentes.Count; i++)
                {
                    comboBox_Categoria.Items.Add(categoriasExistentes[i].CategoryName);
                }
            }
        }

        private void CargarDatosCharPastel()
        {
            List<CategoriasConMasProductosVO> categoriasConMasProductos = NorthWind_BLL.NorthWind_BLL.RealizarConsultaCategoriasMasProductos();

            if (categoriasConMasProductos.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> x1 = new List<string>();
                List<int> y1 = new List<int>();

                for (int i = 0; i < categoriasConMasProductos.Count; i++)
                {
                    x1.Add(categoriasConMasProductos[i].CategoryName);
                    y1.Add(categoriasConMasProductos[i].Cantidad);
                }

                CategoriasMasProductos_Chart.Series["Categorias"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            }
        }

        private void ComboBox_Categoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = comboBox_Categoria.SelectedIndex + 1;
            List<ProductoEnCategoriaVO> list = NorthWind_BLL.NorthWind_BLL.RealizarConsultaProductosEnCategoria(index);
            if (list.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView_Productos_Categoria.DataSource = list;
            }
        }
    }
}
