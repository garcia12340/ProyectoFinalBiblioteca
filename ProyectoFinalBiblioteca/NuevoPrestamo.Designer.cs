
namespace ProyectoFinalBiblioteca
{
    partial class NuevoPrestamo
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
            this.Label10 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtLector = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.dtpFecEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpFecDevolucion = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtCodLector = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCodLibro = new System.Windows.Forms.TextBox();
            this.btnlector = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btndeuda = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
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
            this.Label1.Size = new System.Drawing.Size(831, 52);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Registro de Préstamo";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.DarkCyan;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(58, 75);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(518, 23);
            this.Label10.TabIndex = 26;
            this.Label10.Text = "Datos del Registro";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DarkCyan;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(58, 98);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(518, 137);
            this.Label2.TabIndex = 27;
            // 
            // Label3
            // 
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Location = new System.Drawing.Point(61, 101);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(512, 131);
            this.Label3.TabIndex = 28;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(146, 114);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(40, 13);
            this.Label6.TabIndex = 29;
            this.Label6.Text = "Lector:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(153, 150);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(33, 13);
            this.Label5.TabIndex = 30;
            this.Label5.Text = "Libro:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(91, 181);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(95, 13);
            this.Label7.TabIndex = 31;
            this.Label7.Text = "Fecha de Entrega:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(74, 207);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(112, 13);
            this.Label9.TabIndex = 32;
            this.Label9.Text = "Fecha de Devolución:";
            // 
            // txtLector
            // 
            this.txtLector.BackColor = System.Drawing.Color.White;
            this.txtLector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLector.Location = new System.Drawing.Point(195, 112);
            this.txtLector.Name = "txtLector";
            this.txtLector.ReadOnly = true;
            this.txtLector.Size = new System.Drawing.Size(187, 20);
            this.txtLector.TabIndex = 33;
            // 
            // txtLibro
            // 
            this.txtLibro.BackColor = System.Drawing.Color.White;
            this.txtLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibro.Location = new System.Drawing.Point(195, 148);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.ReadOnly = true;
            this.txtLibro.Size = new System.Drawing.Size(189, 20);
            this.txtLibro.TabIndex = 34;
            // 
            // dtpFecEntrega
            // 
            this.dtpFecEntrega.Enabled = false;
            this.dtpFecEntrega.Location = new System.Drawing.Point(195, 175);
            this.dtpFecEntrega.Name = "dtpFecEntrega";
            this.dtpFecEntrega.Size = new System.Drawing.Size(342, 20);
            this.dtpFecEntrega.TabIndex = 35;
            // 
            // dtpFecDevolucion
            // 
            this.dtpFecDevolucion.Location = new System.Drawing.Point(195, 201);
            this.dtpFecDevolucion.Name = "dtpFecDevolucion";
            this.dtpFecDevolucion.Size = new System.Drawing.Size(342, 20);
            this.dtpFecDevolucion.TabIndex = 36;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(388, 114);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 13);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Código:";
            // 
            // txtCodLector
            // 
            this.txtCodLector.BackColor = System.Drawing.Color.White;
            this.txtCodLector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodLector.Location = new System.Drawing.Point(435, 112);
            this.txtCodLector.Name = "txtCodLector";
            this.txtCodLector.ReadOnly = true;
            this.txtCodLector.Size = new System.Drawing.Size(60, 20);
            this.txtCodLector.TabIndex = 38;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(388, 150);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(43, 13);
            this.Label8.TabIndex = 39;
            this.Label8.Text = "Código:";
            // 
            // txtCodLibro
            // 
            this.txtCodLibro.BackColor = System.Drawing.Color.White;
            this.txtCodLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodLibro.Location = new System.Drawing.Point(435, 148);
            this.txtCodLibro.Name = "txtCodLibro";
            this.txtCodLibro.ReadOnly = true;
            this.txtCodLibro.Size = new System.Drawing.Size(60, 20);
            this.txtCodLibro.TabIndex = 40;
            // 
            // btnlector
            // 
            this.btnlector.BackColor = System.Drawing.Color.DarkCyan;
            this.btnlector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlector.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlector.ForeColor = System.Drawing.Color.White;
            this.btnlector.Location = new System.Drawing.Point(501, 110);
            this.btnlector.Name = "btnlector";
            this.btnlector.Size = new System.Drawing.Size(36, 22);
            this.btnlector.TabIndex = 41;
            this.btnlector.Text = "•••";
            this.btnlector.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlector.UseVisualStyleBackColor = false;
            this.btnlector.Click += new System.EventHandler(this.btnlector_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.Location = new System.Drawing.Point(501, 146);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(36, 22);
            this.btnLibro.TabIndex = 42;
            this.btnLibro.Text = "•••";
            this.btnLibro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLibro.UseVisualStyleBackColor = false;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(604, 75);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(172, 57);
            this.btnRegistrar.TabIndex = 43;
            this.btnRegistrar.Text = "&Registrar Préstamo";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btndeuda
            // 
            this.btndeuda.BackColor = System.Drawing.Color.DarkCyan;
            this.btndeuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeuda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btndeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeuda.ForeColor = System.Drawing.Color.White;
            this.btndeuda.Location = new System.Drawing.Point(604, 176);
            this.btndeuda.Name = "btndeuda";
            this.btndeuda.Size = new System.Drawing.Size(172, 57);
            this.btndeuda.TabIndex = 44;
            this.btndeuda.Text = "&Deuda Lector";
            this.btndeuda.UseVisualStyleBackColor = false;
            this.btndeuda.Click += new System.EventHandler(this.btndeuda_Click);
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.DarkCyan;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(58, 250);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(518, 23);
            this.Label13.TabIndex = 46;
            this.Label13.Text = "Listado de Libros";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.DarkCyan;
            this.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(58, 273);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(518, 167);
            this.Label11.TabIndex = 48;
            // 
            // Label12
            // 
            this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label12.Location = new System.Drawing.Point(61, 275);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(512, 161);
            this.Label12.TabIndex = 49;
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
            this.dgvLibro.Location = new System.Drawing.Point(66, 281);
            this.dgvLibro.MultiSelect = false;
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.ReadOnly = true;
            this.dgvLibro.Size = new System.Drawing.Size(502, 150);
            this.dgvLibro.TabIndex = 50;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Image = global::ProyectoFinalBiblioteca.Properties.Resources.libros3;
            this.PictureBox1.Location = new System.Drawing.Point(604, 250);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(172, 190);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 45;
            this.PictureBox1.TabStop = false;
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 468);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btndeuda);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.btnlector);
            this.Controls.Add(this.txtCodLibro);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtCodLector);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.dtpFecDevolucion);
            this.Controls.Add(this.dtpFecEntrega);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.txtLector);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NuevoPrestamo";
            this.Text = "NuevoPrestamo";
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtLibro;
        internal System.Windows.Forms.DateTimePicker dtpFecEntrega;
        internal System.Windows.Forms.DateTimePicker dtpFecDevolucion;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtCodLector;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCodLibro;
        internal System.Windows.Forms.Button btnlector;
        internal System.Windows.Forms.Button btnLibro;
        internal System.Windows.Forms.Button btnRegistrar;
        internal System.Windows.Forms.Button btndeuda;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.DataGridView dgvLibro;
        internal System.Windows.Forms.TextBox txtLector;
    }
}