
namespace ProyectoFinalBiblioteca
{
    partial class ReportesLibros
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
            this.ReporteLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbbibliotecaDataSet = new ProyectoFinalBiblioteca.dbbibliotecaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteLibrosTableAdapter = new ProyectoFinalBiblioteca.dbbibliotecaDataSetTableAdapters.ReporteLibrosTableAdapter();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteLibrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteLibrosBindingSource
            // 
            this.ReporteLibrosBindingSource.DataMember = "ReporteLibros";
            this.ReporteLibrosBindingSource.DataSource = this.dbbibliotecaDataSet;
            // 
            // dbbibliotecaDataSet
            // 
            this.dbbibliotecaDataSet.DataSetName = "dbbibliotecaDataSet";
            this.dbbibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteLibrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinalBiblioteca.Reportes.ReporteLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(820, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteLibrosTableAdapter
            // 
            this.ReporteLibrosTableAdapter.ClearBeforeFill = true;
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.ForeColor = System.Drawing.Color.White;
            this.BtnReporte.Location = new System.Drawing.Point(23, 457);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(95, 34);
            this.BtnReporte.TabIndex = 2;
            this.BtnReporte.Text = "&GenerarReporte";
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // ReportesLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 492);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesLibros";
            this.Text = "ReportesLibros";
            this.Load += new System.EventHandler(this.ReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteLibrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteLibrosBindingSource;
        private dbbibliotecaDataSet dbbibliotecaDataSet;
        private dbbibliotecaDataSetTableAdapters.ReporteLibrosTableAdapter ReporteLibrosTableAdapter;
        private System.Windows.Forms.Button BtnReporte;
    }
}