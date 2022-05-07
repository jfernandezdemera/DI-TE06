namespace NORTHWIND.ControlesUsuario
{
    partial class ClientesPorCiudadUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesPorCiudadUC));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Search1 = new System.Windows.Forms.TextBox();
            this.button_Search1 = new System.Windows.Forms.Button();
            this.dataGridView_Clientes_Ciudad = new System.Windows.Forms.DataGridView();
            this.label_Cabecera = new System.Windows.Forms.Label();
            this.tt_ClientesCiudad = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes_Ciudad)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Clientes_Ciudad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Cabecera, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1707, 976);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_Search1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Search1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 929);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1701, 44);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // textBox_Search1
            // 
            this.textBox_Search1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Search1.Location = new System.Drawing.Point(0, 0);
            this.textBox_Search1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Search1.Name = "textBox_Search1";
            this.textBox_Search1.Size = new System.Drawing.Size(1360, 20);
            this.textBox_Search1.TabIndex = 0;
            // 
            // button_Search1
            // 
            this.button_Search1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Search1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Search1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search1.Image = ((System.Drawing.Image)(resources.GetObject("button_Search1.Image")));
            this.button_Search1.Location = new System.Drawing.Point(1360, 0);
            this.button_Search1.Margin = new System.Windows.Forms.Padding(0);
            this.button_Search1.Name = "button_Search1";
            this.button_Search1.Size = new System.Drawing.Size(341, 44);
            this.button_Search1.TabIndex = 1;
            this.button_Search1.UseVisualStyleBackColor = true;
            this.button_Search1.Click += new System.EventHandler(this.Button_Search1_Click);
            // 
            // dataGridView_Clientes_Ciudad
            // 
            this.dataGridView_Clientes_Ciudad.AllowUserToAddRows = false;
            this.dataGridView_Clientes_Ciudad.AllowUserToDeleteRows = false;
            this.dataGridView_Clientes_Ciudad.AllowUserToOrderColumns = true;
            this.dataGridView_Clientes_Ciudad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Clientes_Ciudad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Clientes_Ciudad.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Clientes_Ciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Clientes_Ciudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clientes_Ciudad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Clientes_Ciudad.Location = new System.Drawing.Point(0, 48);
            this.dataGridView_Clientes_Ciudad.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Clientes_Ciudad.Name = "dataGridView_Clientes_Ciudad";
            this.dataGridView_Clientes_Ciudad.ReadOnly = true;
            this.dataGridView_Clientes_Ciudad.RowTemplate.Height = 25;
            this.dataGridView_Clientes_Ciudad.Size = new System.Drawing.Size(1707, 878);
            this.dataGridView_Clientes_Ciudad.TabIndex = 5;
            this.dataGridView_Clientes_Ciudad.Tag = "";
            // 
            // label_Cabecera
            // 
            this.label_Cabecera.AutoSize = true;
            this.label_Cabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cabecera.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_Cabecera.Location = new System.Drawing.Point(0, 0);
            this.label_Cabecera.Margin = new System.Windows.Forms.Padding(0);
            this.label_Cabecera.Name = "label_Cabecera";
            this.label_Cabecera.Size = new System.Drawing.Size(1707, 48);
            this.label_Cabecera.TabIndex = 6;
            this.label_Cabecera.Text = "Clientes por ciudad";
            this.label_Cabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientesPorCiudadUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ClientesPorCiudadUC";
            this.Size = new System.Drawing.Size(1707, 976);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes_Ciudad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_Clientes_Ciudad;
        private System.Windows.Forms.Label label_Cabecera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_Search1;
        private System.Windows.Forms.Button button_Search1;
        private System.Windows.Forms.ToolTip tt_ClientesCiudad;
    }
}
