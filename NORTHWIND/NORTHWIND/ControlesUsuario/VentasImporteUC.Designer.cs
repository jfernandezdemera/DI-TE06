namespace NORTHWIND.ControlesUsuario
{
    partial class VentasImporteUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasImporteUC));
            this.tlp_Ventas_Principal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Search2 = new System.Windows.Forms.TextBox();
            this.button_Search2 = new System.Windows.Forms.Button();
            this.dataGridView_Detalle_Venta = new System.Windows.Forms.DataGridView();
            this.label_Detalle_Venta = new System.Windows.Forms.Label();
            this.label_Listado_Ventas = new System.Windows.Forms.Label();
            this.dataGridView_Listado_Ventas = new System.Windows.Forms.DataGridView();
            this.tt_VentasImporte = new System.Windows.Forms.ToolTip(this.components);
            this.tlp_Ventas_Principal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detalle_Venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Ventas_Principal
            // 
            this.tlp_Ventas_Principal.ColumnCount = 2;
            this.tlp_Ventas_Principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Ventas_Principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Ventas_Principal.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tlp_Ventas_Principal.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tlp_Ventas_Principal.Controls.Add(this.dataGridView_Detalle_Venta, 1, 1);
            this.tlp_Ventas_Principal.Controls.Add(this.label_Detalle_Venta, 1, 0);
            this.tlp_Ventas_Principal.Controls.Add(this.label_Listado_Ventas, 0, 0);
            this.tlp_Ventas_Principal.Controls.Add(this.dataGridView_Listado_Ventas, 0, 1);
            this.tlp_Ventas_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Ventas_Principal.Location = new System.Drawing.Point(0, 0);
            this.tlp_Ventas_Principal.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Ventas_Principal.Name = "tlp_Ventas_Principal";
            this.tlp_Ventas_Principal.RowCount = 3;
            this.tlp_Ventas_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_Ventas_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_Ventas_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_Ventas_Principal.Size = new System.Drawing.Size(1707, 976);
            this.tlp_Ventas_Principal.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_Search, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Search, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 929);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(847, 44);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Search.Location = new System.Drawing.Point(0, 0);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(677, 20);
            this.textBox_Search.TabIndex = 0;
            // 
            // button_Search
            // 
            this.button_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Image = ((System.Drawing.Image)(resources.GetObject("button_Search.Image")));
            this.button_Search.Location = new System.Drawing.Point(677, 0);
            this.button_Search.Margin = new System.Windows.Forms.Padding(0);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(170, 44);
            this.button_Search.TabIndex = 1;
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Search2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Search2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(856, 929);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 44);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // textBox_Search2
            // 
            this.textBox_Search2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Search2.Location = new System.Drawing.Point(0, 0);
            this.textBox_Search2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Search2.Name = "textBox_Search2";
            this.textBox_Search2.Size = new System.Drawing.Size(678, 20);
            this.textBox_Search2.TabIndex = 0;
            // 
            // button_Search2
            // 
            this.button_Search2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Search2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search2.Image = ((System.Drawing.Image)(resources.GetObject("button_Search2.Image")));
            this.button_Search2.Location = new System.Drawing.Point(678, 0);
            this.button_Search2.Margin = new System.Windows.Forms.Padding(0);
            this.button_Search2.Name = "button_Search2";
            this.button_Search2.Size = new System.Drawing.Size(170, 44);
            this.button_Search2.TabIndex = 1;
            this.button_Search2.UseVisualStyleBackColor = true;
            this.button_Search2.Click += new System.EventHandler(this.Button_Search2_Click);
            // 
            // dataGridView_Detalle_Venta
            // 
            this.dataGridView_Detalle_Venta.AllowUserToAddRows = false;
            this.dataGridView_Detalle_Venta.AllowUserToDeleteRows = false;
            this.dataGridView_Detalle_Venta.AllowUserToOrderColumns = true;
            this.dataGridView_Detalle_Venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Detalle_Venta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Detalle_Venta.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Detalle_Venta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Detalle_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Detalle_Venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Detalle_Venta.Location = new System.Drawing.Point(853, 48);
            this.dataGridView_Detalle_Venta.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Detalle_Venta.Name = "dataGridView_Detalle_Venta";
            this.dataGridView_Detalle_Venta.ReadOnly = true;
            this.dataGridView_Detalle_Venta.RowTemplate.Height = 25;
            this.dataGridView_Detalle_Venta.Size = new System.Drawing.Size(854, 878);
            this.dataGridView_Detalle_Venta.TabIndex = 6;
            // 
            // label_Detalle_Venta
            // 
            this.label_Detalle_Venta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Detalle_Venta.AutoSize = true;
            this.label_Detalle_Venta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_Detalle_Venta.ForeColor = System.Drawing.Color.Black;
            this.label_Detalle_Venta.Location = new System.Drawing.Point(1200, 12);
            this.label_Detalle_Venta.Name = "label_Detalle_Venta";
            this.label_Detalle_Venta.Size = new System.Drawing.Size(159, 23);
            this.label_Detalle_Venta.TabIndex = 5;
            this.label_Detalle_Venta.Text = "Ventas más baratas";
            this.label_Detalle_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Listado_Ventas
            // 
            this.label_Listado_Ventas.AutoSize = true;
            this.label_Listado_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Listado_Ventas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Listado_Ventas.ForeColor = System.Drawing.Color.Black;
            this.label_Listado_Ventas.Location = new System.Drawing.Point(3, 0);
            this.label_Listado_Ventas.Name = "label_Listado_Ventas";
            this.label_Listado_Ventas.Size = new System.Drawing.Size(847, 48);
            this.label_Listado_Ventas.TabIndex = 4;
            this.label_Listado_Ventas.Text = "Ventas más caras";
            this.label_Listado_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_Listado_Ventas
            // 
            this.dataGridView_Listado_Ventas.AllowUserToAddRows = false;
            this.dataGridView_Listado_Ventas.AllowUserToDeleteRows = false;
            this.dataGridView_Listado_Ventas.AllowUserToOrderColumns = true;
            this.dataGridView_Listado_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Listado_Ventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Listado_Ventas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Listado_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Listado_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listado_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Listado_Ventas.Location = new System.Drawing.Point(0, 48);
            this.dataGridView_Listado_Ventas.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Listado_Ventas.Name = "dataGridView_Listado_Ventas";
            this.dataGridView_Listado_Ventas.ReadOnly = true;
            this.dataGridView_Listado_Ventas.RowTemplate.Height = 25;
            this.dataGridView_Listado_Ventas.Size = new System.Drawing.Size(853, 878);
            this.dataGridView_Listado_Ventas.TabIndex = 1;
            // 
            // VentasImporteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Ventas_Principal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "VentasImporteUC";
            this.Size = new System.Drawing.Size(1707, 976);
            this.tlp_Ventas_Principal.ResumeLayout(false);
            this.tlp_Ventas_Principal.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detalle_Venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado_Ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Ventas_Principal;
        private System.Windows.Forms.DataGridView dataGridView_Detalle_Venta;
        private System.Windows.Forms.Label label_Detalle_Venta;
        private System.Windows.Forms.Label label_Listado_Ventas;
        private System.Windows.Forms.DataGridView dataGridView_Listado_Ventas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_Search2;
        private System.Windows.Forms.Button button_Search2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.ToolTip tt_VentasImporte;
    }
}
