
namespace ProyectoFinalBiblioteca
{
    partial class Genero
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
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNGenero = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtMGenero = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtMCodigo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtECodigo = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
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
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Opciones de Géneros Literarios";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dgvGenero);
            this.GroupBox1.Location = new System.Drawing.Point(6, 61);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(319, 269);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Lista de Registros de Géneros Literarios";
            // 
            // dgvGenero
            // 
            this.dgvGenero.AllowUserToAddRows = false;
            this.dgvGenero.AllowUserToDeleteRows = false;
            this.dgvGenero.AllowUserToResizeColumns = false;
            this.dgvGenero.AllowUserToResizeRows = false;
            this.dgvGenero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvGenero.Location = new System.Drawing.Point(6, 19);
            this.dgvGenero.MultiSelect = false;
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.ReadOnly = true;
            this.dgvGenero.Size = new System.Drawing.Size(307, 244);
            this.dgvGenero.TabIndex = 1;
            this.dgvGenero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenero_CellClick);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.btnAgregar);
            this.GroupBox2.Controls.Add(this.txtNGenero);
            this.GroupBox2.Location = new System.Drawing.Point(341, 61);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(310, 92);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Nuevo Género";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Género:";
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
            // txtNGenero
            // 
            this.txtNGenero.Location = new System.Drawing.Point(51, 37);
            this.txtNGenero.Name = "txtNGenero";
            this.txtNGenero.ShortcutsEnabled = false;
            this.txtNGenero.Size = new System.Drawing.Size(250, 20);
            this.txtNGenero.TabIndex = 0;
            this.txtNGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNGenero_KeyPress);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnModificar);
            this.GroupBox3.Controls.Add(this.txtMGenero);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.txtMCodigo);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Location = new System.Drawing.Point(341, 167);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(310, 76);
            this.GroupBox3.TabIndex = 10;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Modificar Genero";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(10, 46);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(294, 22);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtMGenero
            // 
            this.txtMGenero.Location = new System.Drawing.Point(138, 20);
            this.txtMGenero.Name = "txtMGenero";
            this.txtMGenero.ShortcutsEnabled = false;
            this.txtMGenero.Size = new System.Drawing.Size(166, 20);
            this.txtMGenero.TabIndex = 3;
            this.txtMGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMGenero_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(92, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Genero:";
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
            this.GroupBox4.Controls.Add(this.btnEliminar);
            this.GroupBox4.Controls.Add(this.txtECodigo);
            this.GroupBox4.Controls.Add(this.Label5);
            this.GroupBox4.Location = new System.Drawing.Point(341, 262);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(310, 68);
            this.GroupBox4.TabIndex = 11;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Eliminar Genero";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(138, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 22);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // Genero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 343);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Name = "Genero";
            this.Text = "Genero";
            this.Load += new System.EventHandler(this.Genero_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
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
        internal System.Windows.Forms.DataGridView dgvGenero;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.TextBox txtNGenero;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnModificar;
        internal System.Windows.Forms.TextBox txtMGenero;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtMCodigo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.TextBox txtECodigo;
        internal System.Windows.Forms.Label Label5;
    }
}