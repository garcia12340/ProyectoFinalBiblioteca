
namespace ProyectoFinalBiblioteca
{
    partial class ReportePrestamos
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
            this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbbibliotecaDataSet1 = new ProyectoFinalBiblioteca.dbbibliotecaDataSet1();
            this.ReportePrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportePrestamosTableAdapter = new ProyectoFinalBiblioteca.dbbibliotecaDataSet1TableAdapters.ReportePrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbbibliotecaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePrestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewer1
            // 
            this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportePrestamosBindingSource;
            this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinalBiblioteca.Reportes.ReportePrestamo.rdlc";
            this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer1.Name = "ReportViewer1";
            this.ReportViewer1.ServerReport.BearerToken = null;
            this.ReportViewer1.Size = new System.Drawing.Size(839, 489);
            this.ReportViewer1.TabIndex = 1;
            // 
            // dbbibliotecaDataSet1
            // 
            this.dbbibliotecaDataSet1.DataSetName = "dbbibliotecaDataSet1";
            this.dbbibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportePrestamosBindingSource
            // 
            this.ReportePrestamosBindingSource.DataMember = "ReportePrestamos";
            this.ReportePrestamosBindingSource.DataSource = this.dbbibliotecaDataSet1;
            // 
            // ReportePrestamosTableAdapter
            // 
            this.ReportePrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 489);
            this.Controls.Add(this.ReportViewer1);
            this.Name = "ReportePrestamos";
            this.Text = "ReportePrestamos";
            this.Load += new System.EventHandler(this.ReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbbibliotecaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePrestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
        private System.Windows.Forms.BindingSource ReportePrestamosBindingSource;
        private dbbibliotecaDataSet1 dbbibliotecaDataSet1;
        private dbbibliotecaDataSet1TableAdapters.ReportePrestamosTableAdapter ReportePrestamosTableAdapter;
    }
}