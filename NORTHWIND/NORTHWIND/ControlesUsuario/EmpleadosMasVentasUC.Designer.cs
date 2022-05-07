namespace NORTHWIND.ControlesUsuario
{
    partial class EmpleadosMasVentasUC
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tlp_Empleados = new System.Windows.Forms.TableLayoutPanel();
            this.EmpleadoVentasChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlp_Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoVentasChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Empleados
            // 
            this.tlp_Empleados.ColumnCount = 1;
            this.tlp_Empleados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Empleados.Controls.Add(this.EmpleadoVentasChart, 0, 0);
            this.tlp_Empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Empleados.Location = new System.Drawing.Point(0, 0);
            this.tlp_Empleados.Name = "tlp_Empleados";
            this.tlp_Empleados.RowCount = 1;
            this.tlp_Empleados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Empleados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Empleados.Size = new System.Drawing.Size(1707, 976);
            this.tlp_Empleados.TabIndex = 0;
            // 
            // EmpleadoVentasChart
            // 
            this.EmpleadoVentasChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EmpleadoVentasChart.BorderSkin.BackColor = System.Drawing.Color.Silver;
            this.EmpleadoVentasChart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(102)))));
            this.EmpleadoVentasChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AxisX.Title = "Id Empleado";
            chartArea1.AxisY.Title = "Ventas";
            chartArea1.Name = "ChartArea1";
            this.EmpleadoVentasChart.ChartAreas.Add(chartArea1);
            this.EmpleadoVentasChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpleadoVentasChart.Location = new System.Drawing.Point(0, 0);
            this.EmpleadoVentasChart.Margin = new System.Windows.Forms.Padding(0);
            this.EmpleadoVentasChart.Name = "EmpleadoVentasChart";
            this.EmpleadoVentasChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Ventas";
            this.EmpleadoVentasChart.Series.Add(series1);
            this.EmpleadoVentasChart.Size = new System.Drawing.Size(1707, 976);
            this.EmpleadoVentasChart.TabIndex = 1;
            title1.BorderWidth = 0;
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Ventas por empleado";
            this.EmpleadoVentasChart.Titles.Add(title1);
            // 
            // EmpleadosMasVentasUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.tlp_Empleados);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmpleadosMasVentasUC";
            this.Size = new System.Drawing.Size(1707, 976);
            this.tlp_Empleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoVentasChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Empleados;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmpleadoVentasChart;
    }
}
