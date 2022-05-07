namespace NORTHWIND.ControlesUsuario
{
    partial class EmpleadosMasVentasPeriodoUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tlp_Empleados_Periodo = new System.Windows.Forms.TableLayoutPanel();
            this.EmpleadoVentasPeriodoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlp_IntroduccionFechas = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_FechaDesde = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tlp_FechaHasta = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonAccion = new System.Windows.Forms.Button();
            this.tt_EmpleadosMasVentas = new System.Windows.Forms.ToolTip(this.components);
            this.tlp_Empleados_Periodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoVentasPeriodoChart)).BeginInit();
            this.tlp_IntroduccionFechas.SuspendLayout();
            this.tlp_FechaDesde.SuspendLayout();
            this.tlp_FechaHasta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Empleados_Periodo
            // 
            this.tlp_Empleados_Periodo.BackColor = System.Drawing.Color.White;
            this.tlp_Empleados_Periodo.ColumnCount = 1;
            this.tlp_Empleados_Periodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Empleados_Periodo.Controls.Add(this.EmpleadoVentasPeriodoChart, 0, 1);
            this.tlp_Empleados_Periodo.Controls.Add(this.tlp_IntroduccionFechas, 0, 0);
            this.tlp_Empleados_Periodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Empleados_Periodo.Location = new System.Drawing.Point(0, 0);
            this.tlp_Empleados_Periodo.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Empleados_Periodo.Name = "tlp_Empleados_Periodo";
            this.tlp_Empleados_Periodo.RowCount = 2;
            this.tlp_Empleados_Periodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Empleados_Periodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_Empleados_Periodo.Size = new System.Drawing.Size(1707, 976);
            this.tlp_Empleados_Periodo.TabIndex = 1;
            // 
            // EmpleadoVentasPeriodoChart
            // 
            this.EmpleadoVentasPeriodoChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.EmpleadoVentasPeriodoChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EmpleadoVentasPeriodoChart.BackSecondaryColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmpleadoVentasPeriodoChart.BorderSkin.BackColor = System.Drawing.Color.LightCoral;
            this.EmpleadoVentasPeriodoChart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.EmpleadoVentasPeriodoChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 50;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.AxisX.Title = "Id Empleado";
            chartArea1.AxisY.Title = "Ventas";
            chartArea1.Name = "ChartArea1";
            this.EmpleadoVentasPeriodoChart.ChartAreas.Add(chartArea1);
            this.EmpleadoVentasPeriodoChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpleadoVentasPeriodoChart.Location = new System.Drawing.Point(0, 97);
            this.EmpleadoVentasPeriodoChart.Margin = new System.Windows.Forms.Padding(0);
            this.EmpleadoVentasPeriodoChart.Name = "EmpleadoVentasPeriodoChart";
            this.EmpleadoVentasPeriodoChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Name = "Ventas";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(102)))));
            series1.YValuesPerPoint = 4;
            this.EmpleadoVentasPeriodoChart.Series.Add(series1);
            this.EmpleadoVentasPeriodoChart.Size = new System.Drawing.Size(1707, 879);
            this.EmpleadoVentasPeriodoChart.TabIndex = 1;
            title1.BorderWidth = 0;
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Ventas por empleado en periodo";
            this.EmpleadoVentasPeriodoChart.Titles.Add(title1);
            // 
            // tlp_IntroduccionFechas
            // 
            this.tlp_IntroduccionFechas.ColumnCount = 3;
            this.tlp_IntroduccionFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_IntroduccionFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_IntroduccionFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_IntroduccionFechas.Controls.Add(this.tlp_FechaDesde, 0, 0);
            this.tlp_IntroduccionFechas.Controls.Add(this.tlp_FechaHasta, 1, 0);
            this.tlp_IntroduccionFechas.Controls.Add(this.buttonAccion, 2, 0);
            this.tlp_IntroduccionFechas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_IntroduccionFechas.Location = new System.Drawing.Point(3, 3);
            this.tlp_IntroduccionFechas.Name = "tlp_IntroduccionFechas";
            this.tlp_IntroduccionFechas.RowCount = 1;
            this.tlp_IntroduccionFechas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_IntroduccionFechas.Size = new System.Drawing.Size(1701, 91);
            this.tlp_IntroduccionFechas.TabIndex = 2;
            // 
            // tlp_FechaDesde
            // 
            this.tlp_FechaDesde.BackColor = System.Drawing.Color.White;
            this.tlp_FechaDesde.ColumnCount = 2;
            this.tlp_FechaDesde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_FechaDesde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_FechaDesde.Controls.Add(this.label1, 0, 0);
            this.tlp_FechaDesde.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tlp_FechaDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_FechaDesde.Location = new System.Drawing.Point(3, 3);
            this.tlp_FechaDesde.Name = "tlp_FechaDesde";
            this.tlp_FechaDesde.RowCount = 1;
            this.tlp_FechaDesde.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_FechaDesde.Size = new System.Drawing.Size(561, 85);
            this.tlp_FechaDesde.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(337, 33);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // tlp_FechaHasta
            // 
            this.tlp_FechaHasta.BackColor = System.Drawing.Color.White;
            this.tlp_FechaHasta.ColumnCount = 2;
            this.tlp_FechaHasta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_FechaHasta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_FechaHasta.Controls.Add(this.label2, 0, 0);
            this.tlp_FechaHasta.Controls.Add(this.dateTimePicker2, 1, 0);
            this.tlp_FechaHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_FechaHasta.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlp_FechaHasta.Location = new System.Drawing.Point(570, 3);
            this.tlp_FechaHasta.Name = "tlp_FechaHasta";
            this.tlp_FechaHasta.RowCount = 1;
            this.tlp_FechaHasta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_FechaHasta.Size = new System.Drawing.Size(561, 85);
            this.tlp_FechaHasta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 85);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(224, 0);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(337, 33);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // buttonAccion
            // 
            this.buttonAccion.BackColor = System.Drawing.Color.White;
            this.buttonAccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Ivory;
            this.buttonAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccion.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccion.Location = new System.Drawing.Point(1137, 3);
            this.buttonAccion.Name = "buttonAccion";
            this.buttonAccion.Size = new System.Drawing.Size(561, 85);
            this.buttonAccion.TabIndex = 2;
            this.buttonAccion.Text = "Consultar";
            this.buttonAccion.UseVisualStyleBackColor = false;
            this.buttonAccion.Click += new System.EventHandler(this.ButtonAccion_Click);
            // 
            // EmpleadosMasVentasPeriodoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Empleados_Periodo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmpleadosMasVentasPeriodoUC";
            this.Size = new System.Drawing.Size(1707, 976);
            this.tlp_Empleados_Periodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoVentasPeriodoChart)).EndInit();
            this.tlp_IntroduccionFechas.ResumeLayout(false);
            this.tlp_FechaDesde.ResumeLayout(false);
            this.tlp_FechaDesde.PerformLayout();
            this.tlp_FechaHasta.ResumeLayout(false);
            this.tlp_FechaHasta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Empleados_Periodo;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmpleadoVentasPeriodoChart;
        private System.Windows.Forms.TableLayoutPanel tlp_IntroduccionFechas;
        private System.Windows.Forms.TableLayoutPanel tlp_FechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tlp_FechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonAccion;
        private System.Windows.Forms.ToolTip tt_EmpleadosMasVentas;
    }
}
