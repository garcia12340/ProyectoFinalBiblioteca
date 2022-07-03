
namespace ProyectoFinalBiblioteca
{
    partial class Lector
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
            this.dgvLector = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLector)).BeginInit();
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
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Lectores";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DarkCyan;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.Location = new System.Drawing.Point(40, 93);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(751, 296);
            this.Label2.TabIndex = 19;
            // 
            // dgvLector
            // 
            this.dgvLector.AllowUserToAddRows = false;
            this.dgvLector.AllowUserToDeleteRows = false;
            this.dgvLector.AllowUserToResizeColumns = false;
            this.dgvLector.AllowUserToResizeRows = false;
            this.dgvLector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLector.Location = new System.Drawing.Point(43, 96);
            this.dgvLector.MultiSelect = false;
            this.dgvLector.Name = "dgvLector";
            this.dgvLector.ReadOnly = true;
            this.dgvLector.Size = new System.Drawing.Size(745, 290);
            this.dgvLector.TabIndex = 20;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(43, 399);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(105, 46);
            this.BtnNuevo.TabIndex = 21;
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
            this.BtnModificar.Location = new System.Drawing.Point(565, 399);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(105, 46);
            this.BtnModificar.TabIndex = 22;
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
            this.BtnEliminar.Location = new System.Drawing.Point(686, 399);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(105, 46);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(40, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(147, 13);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "&Lista de Lectores Registrados";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(715, 76);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(34, 13);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "&Total:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(755, 76);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblRegistros.TabIndex = 26;
            this.lblRegistros.Text = "0";
            // 
            // Lector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 455);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.dgvLector);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Lector";
            this.Text = "Lector";
            this.Load += new System.EventHandler(this.Lector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dgvLector;
        internal System.Windows.Forms.Button BtnNuevo;
        internal System.Windows.Forms.Button BtnModificar;
        internal System.Windows.Forms.Button BtnEliminar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblRegistros;
    }
}