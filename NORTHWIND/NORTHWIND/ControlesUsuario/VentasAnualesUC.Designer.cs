namespace NORTHWIND.ControlesUsuario
{
    partial class VentasAnualesUC
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
            this.tlp_VentasAnuales = new System.Windows.Forms.TableLayoutPanel();
            this.chart_Ventas_Anuales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlp_VentasAnuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Ventas_Anuales)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_VentasAnuales
            // 
            this.tlp_VentasAnuales.BackColor = System.Drawing.Color.White;
            this.tlp_VentasAnuales.ColumnCount = 1;
            this.tlp_VentasAnuales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_VentasAnuales.Controls.Add(this.chart_Ventas_Anuales, 0, 0);
            this.tlp_VentasAnuales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_VentasAnuales.Location = new System.Drawing.Point(0, 0);
            this.tlp_VentasAnuales.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_VentasAnuales.Name = "tlp_VentasAnuales";
            this.tlp_VentasAnuales.RowCount = 1;
            this.tlp_VentasAnuales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_VentasAnuales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_VentasAnuales.Size = new System.Drawing.Size(1707, 976);
            this.tlp_VentasAnuales.TabIndex = 0;
            // 
            // chart_Ventas_Anuales
            // 
            this.chart_Ventas_Anuales.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart_Ventas_Anuales.ChartAreas.Add(chartArea1);
            this.chart_Ventas_Anuales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            legend1.Name = "Legend1";
            this.chart_Ventas_Anuales.Legends.Add(legend1);
            this.chart_Ventas_Anuales.Location = new System.Drawing.Point(0, 0);
            this.chart_Ventas_Anuales.Margin = new System.Windows.Forms.Padding(0);
            this.chart_Ventas_Anuales.Name = "chart_Ventas_Anuales";
            this.chart_Ventas_Anuales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_Ventas_Anuales.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Gray,
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Black};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series1.Legend = "Legend1";
            series1.Name = "Anios";
            series1.YValuesPerPoint = 4;
            this.chart_Ventas_Anuales.Series.Add(series1);
            this.chart_Ventas_Anuales.Size = new System.Drawing.Size(1707, 976);
            this.chart_Ventas_Anuales.TabIndex = 0;
            this.chart_Ventas_Anuales.Text = "chart1";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Ventas Anuales";
            this.chart_Ventas_Anuales.Titles.Add(title1);
            // 
            // VentasAnualesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlp_VentasAnuales);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "VentasAnualesUC";
            this.Size = new System.Drawing.Size(1707, 976);
            this.tlp_VentasAnuales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Ventas_Anuales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_VentasAnuales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Ventas_Anuales;
    }
}
