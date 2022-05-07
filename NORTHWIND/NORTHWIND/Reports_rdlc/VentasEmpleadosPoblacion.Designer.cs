
namespace NORTHWIND.Reports_rdlc
{
    partial class VentasEmpleadosPoblacion
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new NORTHWIND.Reports_rdlc.DataSet1();
            this.Employee_Sales_by_CountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Employee_Sales_by_CountryTableAdapter = new NORTHWIND.Reports_rdlc.DataSet1TableAdapters.Employee_Sales_by_CountryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Sales_by_CountryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Employee_Sales_by_CountryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NORTHWIND.Reports_rdlc.VentasEmpleadosPoblacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Employee_Sales_by_CountryBindingSource
            // 
            this.Employee_Sales_by_CountryBindingSource.DataMember = "Employee Sales by Country";
            this.Employee_Sales_by_CountryBindingSource.DataSource = this.DataSet1;
            // 
            // Employee_Sales_by_CountryTableAdapter
            // 
            this.Employee_Sales_by_CountryTableAdapter.ClearBeforeFill = true;
            // 
            // VentasEmpleadosPoblacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VentasEmpleadosPoblacion";
            this.Text = "VentasEmpleadosPoblacion";
            this.Load += new System.EventHandler(this.VentasEmpleadosPoblacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Sales_by_CountryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Employee_Sales_by_CountryBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.Employee_Sales_by_CountryTableAdapter Employee_Sales_by_CountryTableAdapter;
    }
}