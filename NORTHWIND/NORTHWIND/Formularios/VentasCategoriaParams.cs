using CategoriasExistentes;
using NORTHWIND.Reports_rdlc;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VentasAnuales;

namespace NORTHWIND.Formularios
{
    public partial class VentasCategoriaParams : Form
    {
        private List<CategoriasExistentesVO> categorias;
        public VentasCategoriaParams()
        {
            InitializeComponent();
            CargarDatosCombo();
        }

        private void CargarDatosCombo()
        {
            categorias = NorthWind_BLL.NorthWind_BLL.RealizarConsultaCategoriasExistentes();

            if (categorias.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < categorias.Count; i++)
                {
                    comboBox_categoria.Items.Add(categorias[i].CategoryName);
                }
            }

            List<VentasAnualesVO> ventasAnualesList = NorthWind_BLL.NorthWind_BLL.RealizarConsultaVentasAno();

            if (ventasAnualesList.Count == 0)
            {
                MessageBox.Show("Error en la consulta con la BBDD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<object> anio = new List<object>();

                for (int i = 0; i < ventasAnualesList.Count; i++)
                {
                    if (!anio.Contains(ventasAnualesList[i].Anio)) { anio.Add(ventasAnualesList[i].Anio); }
                }

                anio.Sort();
                comboBox_anio.Items.AddRange(anio.ToArray());
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            string anio = comboBox_anio.SelectedItem.ToString();
            string categoria = comboBox_categoria.SelectedItem.ToString();
            VentasCategoria ventasCategoria = new VentasCategoria();
            if (anio != null && categoria != null)
            {
                ventasCategoria.Anio = anio;
                ventasCategoria.Categoria = categoria;
                this.Close();
                ventasCategoria.Show();
            }
            else
            {
                MessageBox.Show("REVISA LOS CAMPOS SELECCIONADOS!!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
