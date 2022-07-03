
namespace ProyectoFinalBiblioteca
{
    partial class Editorial
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEditorial = new System.Windows.Forms.DataGridView();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNEditorial = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.txtMEditorial = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtMCodigo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.txtECodigo = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorial)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.OrangeRed;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(659, 48);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Opciones de Editoriales";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dgvEditorial);
            this.GroupBox1.Location = new System.Drawing.Point(6, 60);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(319, 269);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Lista de Registros de Editoriales";
            // 
            // dgvEditorial
            // 
            this.dgvEditorial.AllowUserToAddRows = false;
            this.dgvEditorial.AllowUserToDeleteRows = false;
            this.dgvEditorial.AllowUserToResizeColumns = false;
            this.dgvEditorial.AllowUserToResizeRows = false;
            this.dgvEditorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEditorial.Location = new System.Drawing.Point(6, 19);
            this.dgvEditorial.MultiSelect = false;
            this.dgvEditorial.Name = "dgvEditorial";
            this.dgvEditorial.ReadOnly = true;
            this.dgvEditorial.Size = new System.Drawing.Size(307, 244);
            this.dgvEditorial.TabIndex = 1;
            this.dgvEditorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditorial_CellClick);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.btnAgregar);
            this.GroupBox2.Controls.Add(this.txtNEditorial);
            this.GroupBox2.Location = new System.Drawing.Point(341, 60);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(310, 92);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Nueva Editorial";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Editorial:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(6, 63);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(294, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNEditorial
            // 
            this.txtNEditorial.Location = new System.Drawing.Point(59, 37);
            this.txtNEditorial.Name = "txtNEditorial";
            this.txtNEditorial.ShortcutsEnabled = false;
            this.txtNEditorial.Size = new System.Drawing.Size(241, 20);
            this.txtNEditorial.TabIndex = 0;
            this.txtNEditorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNEditorial_KeyPress);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.BtnModificar);
            this.GroupBox3.Controls.Add(this.txtMEditorial);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.txtMCodigo);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Location = new System.Drawing.Point(341, 166);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(310, 76);
            this.GroupBox3.TabIndex = 14;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Modificar Editorial";
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(10, 46);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(294, 22);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // txtMEditorial
            // 
            this.txtMEditorial.Location = new System.Drawing.Point(138, 20);
            this.txtMEditorial.Name = "txtMEditorial";
            this.txtMEditorial.ShortcutsEnabled = false;
            this.txtMEditorial.Size = new System.Drawing.Size(166, 20);
            this.txtMEditorial.TabIndex = 3;
            this.txtMEditorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMEditorial_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(92, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Editorial:";
            // 
            // txtMCodigo
            // 
            this.txtMCodigo.Location = new System.Drawing.Point(50, 20);
            this.txtMCodigo.Name = "txtMCodigo";
            this.txtMCodigo.ShortcutsEnabled = false;
            this.txtMCodigo.Size = new System.Drawing.Size(41, 20);
            this.txtMCodigo.TabIndex = 1;
            this.txtMCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMCodigo_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Codigo:";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.BtnEliminar);
            this.GroupBox4.Controls.Add(this.txtECodigo);
            this.GroupBox4.Controls.Add(this.Label5);
            this.GroupBox4.Location = new System.Drawing.Point(341, 261);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(310, 68);
            this.GroupBox4.TabIndex = 15;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Eliminar Editorial";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(138, 28);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(161, 22);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtECodigo
            // 
            this.txtECodigo.Location = new System.Drawing.Point(59, 30);
            this.txtECodigo.Name = "txtECodigo";
            this.txtECodigo.ShortcutsEnabled = false;
            this.txtECodigo.Size = new System.Drawing.Size(68, 20);
            this.txtECodigo.TabIndex = 1;
            this.txtECodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtECodigo_KeyPress);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 33);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(43, 13);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Código:";
            // 
            // Editorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 343);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Name = "Editorial";
            this.Text = "Editorial";
            this.Load += new System.EventHandler(this.Editorial_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorial)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dgvEditorial;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.TextBox txtNEditorial;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button BtnModificar;
        internal System.Windows.Forms.TextBox txtMEditorial;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtMCodigo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button BtnEliminar;
        internal System.Windows.Forms.TextBox txtECodigo;
        internal System.Windows.Forms.Label Label5;
    }
}