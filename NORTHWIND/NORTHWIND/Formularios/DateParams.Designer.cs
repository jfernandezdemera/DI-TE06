
namespace NORTHWIND.Formularios
{
    partial class DateParams
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
            this.dateTimePicker_desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_hasta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // dateTimePicker_desde
            // 
            this.dateTimePicker_desde.Location = new System.Drawing.Point(146, 53);
            this.dateTimePicker_desde.Name = "dateTimePicker_desde";
            this.dateTimePicker_desde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_desde.TabIndex = 4;
            // 
            // dateTimePicker_hasta
            // 
            this.dateTimePicker_hasta.Location = new System.Drawing.Point(146, 100);
            this.dateTimePicker_hasta.Name = "dateTimePicker_hasta";
            this.dateTimePicker_hasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_hasta.TabIndex = 5;
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Clickame para generar el informe");
            this.button1.Location = new System.Drawing.Point(146, 154);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(199, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "GENERAR INFORME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "FECHA DESDE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "FECHA HASTA:";
            // 
            // DateParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker_hasta);
            this.Controls.Add(this.dateTimePicker_desde);
            this.HelpButton = true;
            this.helpProvider1.SetHelpString(this, "Cierra el PopUp");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateParams";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "INTRODUCCIÓN PARÁMETROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hasta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}