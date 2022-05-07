using System;
using System.Windows.Forms;

namespace BusquedaDataGridViewCommon
{
    /// <summary>
    /// Clase para implementar la busqueda de datos dentro de un DataGridView
    /// </summary>
    public class BusquedaDataGridView
    {
        public BusquedaDataGridView(DataGridView dataGridView, string text)
        {
            try
            {
                // Nos recorremos las columnas
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    // Nos recorremos las celdas
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Buscamos el datos
                        if (cell.Value.ToString().Contains(text))
                        {
                            // Nos posicionamos en la celda si se encuentra el dato
                            dataGridView.CurrentCell = cell;
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        static void Main() { }
    }
}
