
namespace NORTHWIND.Formularios
{
    partial class IdPedidosRdlcParams
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxParams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Clickame para generar el informe");
            this.button1.Location = new System.Drawing.Point(140, 137);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(199, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "GENERAR INFORME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBoxParams
            // 
            this.comboBoxParams.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.comboBoxParams, "Selecciona el pedido para generar el informe");
            this.helpProvider1.SetHelpString(this.comboBoxParams, "Selecciona el pedido para mostrar el informe");
            this.comboBoxParams.Location = new System.Drawing.Point(106, 56);
            this.comboBoxParams.Name = "comboBoxParams";
            this.helpProvider1.SetShowHelp(this.comboBoxParams, true);
            this.comboBoxParams.Size = new System.Drawing.Size(278, 21);
            this.comboBoxParams.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECCIONA ID PEDIDO:";
            // 
            // IdPedidosRdlcParams
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
            this.Name = "IdPedidosRdlcParams";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "INTRODUCCIÓN PARÁMETROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}