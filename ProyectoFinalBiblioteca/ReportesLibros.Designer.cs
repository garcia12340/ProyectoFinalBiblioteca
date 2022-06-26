
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
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteLibrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinalBiblioteca.Reportes.ReporteLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(820, 472);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteLibrosTableAdapter
            // 
            this.ReporteLibrosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 472);
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
    }
}