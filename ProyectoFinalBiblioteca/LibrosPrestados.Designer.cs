
namespace ProyectoFinalBiblioteca
{
    partial class LibrosPrestados
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
            this.Label6 = new System.Windows.Forms.Label();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DarkCyan;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(834, 42);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Listado de libros Prestados";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label5.Location = new System.Drawing.Point(0, 42);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(834, 44);
            this.Label5.TabIndex = 28;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label6.Location = new System.Drawing.Point(477, 56);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(61, 13);
            this.Label6.TabIndex = 29;
            this.Label6.Text = "Buscar por:";
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Items.AddRange(new object[] {
            "Lector",
            "Titulo"});
            this.cboBusqueda.Location = new System.Drawing.Point(544, 53);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cboBusqueda.TabIndex = 30;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(671, 54);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(148, 20);
            this.txtBusqueda.TabIndex = 31;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(43, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(155, 13);
            this.Label3.TabIndex = 32;
            this.Label3.Text = "&Lista de Prestamos Registrados";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(718, 90);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(34, 13);
            this.Label4.TabIndex = 33;
            this.Label4.Text = "&Total:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(758, 90);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblRegistros.TabIndex = 34;
            this.lblRegistros.Text = "0";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(46, 406);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 46);
            this.btnImprimir.TabIndex = 35;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.ForeColor = System.Drawing.Color.White;
            this.btnRetornar.Location = new System.Drawing.Point(686, 406);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(105, 46);
            this.btnRetornar.TabIndex = 36;
            this.btnRetornar.Text = "&Retornar";
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DarkCyan;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.Location = new System.Drawing.Point(43, 107);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(751, 287);
            this.Label2.TabIndex = 37;
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AllowUserToAddRows = false;
            this.dgvPrestamo.AllowUserToDeleteRows = false;
            this.dgvPrestamo.AllowUserToResizeColumns = false;
            this.dgvPrestamo.AllowUserToResizeRows = false;
            this.dgvPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPrestamo.Location = new System.Drawing.Point(46, 110);
            this.dgvPrestamo.MultiSelect = false;
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.ReadOnly = true;
            this.dgvPrestamo.Size = new System.Drawing.Size(745, 281);
            this.dgvPrestamo.TabIndex = 38;
            // 
            // LibrosPrestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 466);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Name = "LibrosPrestados";
            this.Text = "LibrosPrestados";
            this.Load += new System.EventHandler(this.LibrosPrestados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cboBusqueda;
        internal System.Windows.Forms.TextBox txtBusqueda;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblRegistros;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Button btnRetornar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dgvPrestamo;
    }
}