
namespace NORTHWIND.Formularios
{
    partial class VentasCategoriaParams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.comboBox_anio = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "SELECCIONA AÑO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "SELECCIONA CATEGORIA:";
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Clickame para generar el informe");
            this.button1.Location = new System.Drawing.Point(141, 168);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(199, 75);
            this.button1.TabIndex = 11;
            this.button1.Text = "GENERAR INFORME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.comboBox_categoria, "Selecciona la Categoría para el informe");
            this.comboBox_categoria.Location = new System.Drawing.Point(144, 71);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.helpProvider1.SetShowHelp(this.comboBox_categoria, true);
            this.comboBox_categoria.Size = new System.Drawing.Size(196, 21);
            this.comboBox_categoria.TabIndex = 14;
            // 
            // comboBox_anio
            // 
            this.comboBox_anio.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.comboBox_anio, "Seleccionar el año para el informe");
            this.comboBox_anio.Location = new System.Drawing.Point(144, 115);
            this.comboBox_anio.Name = "comboBox_anio";
            this.helpProvider1.SetShowHelp(this.comboBox_anio, true);
            this.comboBox_anio.Size = new System.Drawing.Size(196, 21);
            this.comboBox_anio.TabIndex = 15;
            // 
            // VentasCategoriaParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 316);
            this.Controls.Add(this.comboBox_anio);
            this.Controls.Add(this.comboBox_categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.helpProvider1.SetHelpString(this, "Cierra el PopUp");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentasCategoriaParams";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "INTRODUCCIÓN PARÁMETROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.ComboBox comboBox_anio;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}