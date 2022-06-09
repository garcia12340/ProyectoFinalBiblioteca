
namespace ProyectoFinalBiblioteca
{
    partial class Bibliotecario
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
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.dgvBibliotecario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecario)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DarkCyan;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(815, 65);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Bibliotecarios";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DarkCyan;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.Location = new System.Drawing.Point(40, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(751, 296);
            this.Label2.TabIndex = 10;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(43, 400);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(105, 46);
            this.BtnNuevo.TabIndex = 12;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(565, 400);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(105, 46);
            this.BtnModificar.TabIndex = 13;
            this.BtnModificar.Text = "&Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(686, 400);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(105, 46);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(40, 77);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(168, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "&Lista de Bibliotecarios Registrados";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(715, 77);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(34, 13);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "&Total:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(755, 77);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblRegistros.TabIndex = 17;
            this.lblRegistros.Text = "0";
            // 
            // dgvBibliotecario
            // 
            this.dgvBibliotecario.AllowUserToAddRows = false;
            this.dgvBibliotecario.AllowUserToDeleteRows = false;
            this.dgvBibliotecario.AllowUserToResizeColumns = false;
            this.dgvBibliotecario.AllowUserToResizeRows = false;
            this.dgvBibliotecario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBibliotecario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBibliotecario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBibliotecario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBibliotecario.Location = new System.Drawing.Point(43, 97);
            this.dgvBibliotecario.MultiSelect = false;
            this.dgvBibliotecario.Name = "dgvBibliotecario";
            this.dgvBibliotecario.ReadOnly = true;
            this.dgvBibliotecario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBibliotecario.Size = new System.Drawing.Size(745, 290);
            this.dgvBibliotecario.TabIndex = 18;
            this.dgvBibliotecario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBibliotecario_CellClick);
            // 
            // Bibliotecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 453);
            this.Controls.Add(this.dgvBibliotecario);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Bibliotecario";
            this.Text = "Bibliotecario";
            this.Load += new System.EventHandler(this.Bibliotecario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnNuevo;
        internal System.Windows.Forms.Button BtnModificar;
        internal System.Windows.Forms.Button BtnEliminar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblRegistros;
        internal System.Windows.Forms.DataGridView dgvBibliotecario;
    }
}