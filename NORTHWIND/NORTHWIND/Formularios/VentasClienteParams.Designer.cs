
namespace NORTHWIND.Reports_rdlc
{
    partial class VentasClienteParams
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
            this.comboBoxParams = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // comboBoxParams
            // 
            this.comboBoxParams.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.comboBoxParams, "Selecciona el cliente para generar el informe con sus compras");
            this.comboBoxParams.Location = new System.Drawing.Point(112, 68);
            this.comboBoxParams.Name = "comboBoxParams";
            this.helpProvider1.SetShowHelp(this.comboBoxParams, true);
            this.comboBoxParams.Size = new System.Drawing.Size(278, 21);
            this.comboBoxParams.TabIndex = 0;
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Clickame para generar el informe");
            this.button1.Location = new System.Drawing.Point(146, 149);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(199, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "GENERAR INFORME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECCIONA CLIENTE:";
            // 
            // VentasClienteParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxParams);
            this.HelpButton = true;
            this.helpProvider1.SetHelpString(this, "Cierra el PopUp");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentasClienteParams";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "INTRODUCCIÓN PARÁMETROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxParams;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}