
namespace ProyectoFinalBiblioteca
{
    partial class VistaLibros
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DarkCyan;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(635, 23);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Doble Click sobre el Libro para Elegirlo";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label5.Location = new System.Drawing.Point(0, 23);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(635, 34);
            this.Label5.TabIndex = 23;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DarkCyan;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.Location = new System.Drawing.Point(4, 62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(628, 273);
            this.Label2.TabIndex = 24;
            // 
            // dgvLibro
            // 
            this.dgvLibro.AllowUserToAddRows = false;
            this.dgvLibro.AllowUserToDeleteRows = false;
            this.dgvLibro.AllowUserToResizeColumns = false;
            this.dgvLibro.AllowUserToResizeRows = false;
            this.dgvLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLibro.Location = new System.Drawing.Point(7, 65);
            this.dgvLibro.MultiSelect = false;
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.ReadOnly = true;
            this.dgvLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibro.Size = new System.Drawing.Size(622, 267);
            this.dgvLibro.TabIndex = 25;
            this.dgvLibro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibro_CellDoubleClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(486, 31);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(148, 20);
            this.txtBusqueda.TabIndex = 26;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Items.AddRange(new object[] {
            "Titulo",
            "Autor",
            "Genero",
            "Editorial"});
            this.cboBusqueda.Location = new System.Drawing.Point(359, 30);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cboBusqueda.TabIndex = 27;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label6.Location = new System.Drawing.Point(292, 33);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(61, 13);
            this.Label6.TabIndex = 28;
            this.Label6.Text = "Buscar por:";
            // 
            // VistaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 338);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Name = "VistaLibros";
            this.Text = "VistaLibros";
            this.Load += new System.EventHandler(this.VistaLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dgvLibro;
        internal System.Windows.Forms.TextBox txtBusqueda;
        internal System.Windows.Forms.ComboBox cboBusqueda;
        internal System.Windows.Forms.Label Label6;
    }
}