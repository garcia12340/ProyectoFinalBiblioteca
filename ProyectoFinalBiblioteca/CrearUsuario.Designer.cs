
namespace ProyectoFinalBiblioteca
{
    partial class CrearUsuario
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
            this.gbdatos = new System.Windows.Forms.GroupBox();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontrasenia = new System.Windows.Forms.TextBox();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.gbdatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdatos
            // 
            this.gbdatos.Controls.Add(this.txtidusuario);
            this.gbdatos.Controls.Add(this.label1);
            this.gbdatos.Controls.Add(this.label2);
            this.gbdatos.Controls.Add(this.label3);
            this.gbdatos.Controls.Add(this.label4);
            this.gbdatos.Controls.Add(this.label5);
            this.gbdatos.Controls.Add(this.cboestado);
            this.gbdatos.Controls.Add(this.txtnombres);
            this.gbdatos.Controls.Add(this.label8);
            this.gbdatos.Controls.Add(this.txtapellidos);
            this.gbdatos.Controls.Add(this.txtusuario);
            this.gbdatos.Controls.Add(this.txtcontrasenia);
            this.gbdatos.Controls.Add(this.cborol);
            this.gbdatos.Location = new System.Drawing.Point(7, 4);
            this.gbdatos.Name = "gbdatos";
            this.gbdatos.Size = new System.Drawing.Size(642, 100);
            this.gbdatos.TabIndex = 47;
            this.gbdatos.TabStop = false;
            this.gbdatos.Text = "Datos";
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(13, 66);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(48, 20);
            this.txtidusuario.TabIndex = 20;
            this.txtidusuario.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña:";
            // 
            // cboestado
            // 
            this.cboestado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(495, 47);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(141, 21);
            this.cboestado.TabIndex = 16;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(67, 19);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(142, 20);
            this.txtnombres.TabIndex = 6;
            this.txtnombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(450, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Estado:";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(292, 19);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(143, 20);
            this.txtapellidos.TabIndex = 7;
            this.txtapellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidos_KeyPress);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(67, 47);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(142, 20);
            this.txtusuario.TabIndex = 8;
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.Location = new System.Drawing.Point(292, 47);
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.Size = new System.Drawing.Size(143, 20);
            this.txtcontrasenia.TabIndex = 9;
            // 
            // cborol
            // 
            this.cborol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(495, 19);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(141, 21);
            this.cborol.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalRegistros);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtFilter);
            this.groupBox2.Controls.Add(this.cboFiltro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dgvdata);
            this.groupBox2.Location = new System.Drawing.Point(7, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 275);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Usuarios";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.BackColor = System.Drawing.Color.White;
            this.lblTotalRegistros.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRegistros.Location = new System.Drawing.Point(726, 253);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblTotalRegistros.TabIndex = 23;
            this.lblTotalRegistros.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(627, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total Registros :";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(593, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 20);
            this.txtFilter.TabIndex = 21;
            // 
            // cboFiltro
            // 
            this.cboFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(461, 19);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(121, 21);
            this.cboFiltro.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(401, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Filtrar  por:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvdata.Location = new System.Drawing.Point(6, 48);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(740, 198);
            this.dgvdata.TabIndex = 18;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(671, 26);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(88, 23);
            this.BtnGuardar.TabIndex = 49;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Visible = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(671, 26);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(88, 23);
            this.BtnNuevo.TabIndex = 50;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(671, 53);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(88, 23);
            this.BtnCancelar.TabIndex = 51;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(671, 53);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(88, 23);
            this.BtnEditar.TabIndex = 52;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(671, 81);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(88, 23);
            this.BtnEliminar.TabIndex = 53;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 406);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbdatos);
            this.Name = "CrearUsuario";
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            this.gbdatos.ResumeLayout(false);
            this.gbdatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontrasenia;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox txtidusuario;
    }
}