namespace NORTHWIND.ControlesUsuario
{
    partial class ProductosCategoriaUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tlp_Categorias_Prodcutos = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CategoriasMasProductos_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.dataGridView_Productos_Categoria = new System.Windows.Forms.DataGridView();
            this.tlp_Categorias_Prodcutos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasMasProductos_Chart)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Categorias_Prodcutos
            // 
            this.tlp_Categorias_Prodcutos.ColumnCount = 1;
            this.tlp_Categorias_Prodcutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Categorias_Prodcutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Categorias_Prodcutos.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlp_Categorias_Prodcutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Categorias_Prodcutos.Location = new System.Drawing.Point(0, 0);
            this.tlp_Categorias_Prodcutos.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Categorias_Prodcutos.Name = "tlp_Categorias_Prodcutos";
            this.tlp_Categorias_Prodcutos.RowCount = 1;
            this.tlp_Categorias_Prodcutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Categorias_Prodcutos.Size = new System.Drawing.Size(1707, 976);
            this.tlp_Categorias_Prodcutos.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.CategoriasMasProductos_Chart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1701, 970);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CategoriasMasProductos_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.CategoriasMasProductos_Chart.ChartAreas.Add(chartArea1);
            this.CategoriasMasProductos_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.CategoriasMasProductos_Chart.Legends.Add(legend1);
            this.CategoriasMasProductos_Chart.Location = new System.Drawing.Point(0, 0);
            this.CategoriasMasProductos_Chart.Margin = new System.Windows.Forms.Padding(0);
            this.CategoriasMasProductos_Chart.Name = "CategoriasMasProductos_Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderWidth = 0;
            series1.Legend = "Legend1";
            series1.Name = "Categorias";
            this.CategoriasMasProductos_Chart.Series.Add(series1);
            this.CategoriasMasProductos_Chart.Size = new System.Drawing.Size(1701, 485);
            this.CategoriasMasProductos_Chart.TabIndex = 2;
            title1.Name = "Title1";
            title1.Text = "Categorias con más productos";
            this.CategoriasMasProductos_Chart.Titles.Add(title1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox_Categoria, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_Productos_Categoria, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 488);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1695, 479);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(3, 3);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(1689, 21);
            this.comboBox_Categoria.TabIndex = 0;
            this.comboBox_Categoria.Text = "Selecciones categoría";
            this.comboBox_Categoria.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Categoria_SelectionChangeCommitted);
            // 
            // dataGridView_Productos_Categoria
            // 
            this.dataGridView_Productos_Categoria.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Productos_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Productos_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Productos_Categoria.Location = new System.Drawing.Point(0, 47);
            this.dataGridView_Productos_Categoria.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Productos_Categoria.Name = "dataGridView_Productos_Categoria";
            this.dataGridView_Productos_Categoria.Size = new System.Drawing.Size(1695, 432);
            this.dataGridView_Productos_Categoria.TabIndex = 1;
            // 
            // ProductosCategoriaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Categorias_Prodcutos);
            this.Name = "ProductosCategoriaUC";
            this.Size = new System.Drawing.Size(1707, 976);
            this.tlp_Categorias_Prodcutos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasMasProductos_Chart)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos_Categoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Categorias_Prodcutos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CategoriasMasProductos_Chart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
        private System.Windows.Forms.DataGridView dataGridView_Productos_Categoria;
    }
}
