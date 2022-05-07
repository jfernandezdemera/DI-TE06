namespace NORTHWIND.ControlesUsuario
{
    partial class ProductosOrdenadosUC
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProductosBaratosChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ProductosCarosChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBaratosChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosCarosChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ProductosBaratosChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProductosCarosChart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1707, 976);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ProductosBaratosChart
            // 
            this.ProductosBaratosChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProductosBaratosChart.BorderSkin.BackColor = System.Drawing.Color.Silver;
            this.ProductosBaratosChart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(102)))));
            this.ProductosBaratosChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle8;
            chartArea1.AxisY.Title = "Precio";
            chartArea1.Name = "ChartArea1";
            this.ProductosBaratosChart.ChartAreas.Add(chartArea1);
            this.ProductosBaratosChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ProductosBaratosChart.Legends.Add(legend1);
            this.ProductosBaratosChart.Location = new System.Drawing.Point(0, 488);
            this.ProductosBaratosChart.Margin = new System.Windows.Forms.Padding(0);
            this.ProductosBaratosChart.Name = "ProductosBaratosChart";
            this.ProductosBaratosChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.ProductosBaratosChart.Size = new System.Drawing.Size(1707, 488);
            this.ProductosBaratosChart.TabIndex = 2;
            title1.BorderWidth = 0;
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Productos más baratos";
            this.ProductosBaratosChart.Titles.Add(title1);
            // 
            // ProductosCarosChart
            // 
            this.ProductosCarosChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProductosCarosChart.BorderSkin.BackColor = System.Drawing.Color.Silver;
            this.ProductosCarosChart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(102)))));
            this.ProductosCarosChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle8;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Title = "Precio";
            chartArea2.Name = "ChartArea1";
            this.ProductosCarosChart.ChartAreas.Add(chartArea2);
            this.ProductosCarosChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ProductosCarosChart.Legends.Add(legend2);
            this.ProductosCarosChart.Location = new System.Drawing.Point(0, 0);
            this.ProductosCarosChart.Margin = new System.Windows.Forms.Padding(0);
            this.ProductosCarosChart.Name = "ProductosCarosChart";
            this.ProductosCarosChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.ProductosCarosChart.Size = new System.Drawing.Size(1707, 488);
            this.ProductosCarosChart.TabIndex = 1;
            title2.BorderWidth = 0;
            title2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Productos más caros";
            this.ProductosCarosChart.Titles.Add(title2);
            // 
            // ProductosOrdenadosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductosOrdenadosUC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1707, 976);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBaratosChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosCarosChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProductosCarosChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProductosBaratosChart;
    }
}
