
namespace ProyectoFinalBiblioteca
{
    partial class RolPermiso
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.BtnBuscarPermisos = new System.Windows.Forms.Button();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rol:";
            // 
            // cboRol
            // 
            this.cboRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(38, 8);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(216, 21);
            this.cboRol.TabIndex = 7;
            // 
            // BtnBuscarPermisos
            // 
            this.BtnBuscarPermisos.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnBuscarPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarPermisos.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarPermisos.Location = new System.Drawing.Point(354, 6);
            this.BtnBuscarPermisos.Name = "BtnBuscarPermisos";
            this.BtnBuscarPermisos.Size = new System.Drawing.Size(110, 23);
            this.BtnBuscarPermisos.TabIndex = 8;
            this.BtnBuscarPermisos.Text = "Buscar Permisos";
            this.BtnBuscarPermisos.UseVisualStyleBackColor = false;
            this.BtnBuscarPermisos.Click += new System.EventHandler(this.BtnBuscarPermisos_Click);
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPermisos.Location = new System.Drawing.Point(9, 36);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(460, 297);
            this.dgvPermisos.TabIndex = 9;
            this.dgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellContentClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 304);
            this.label2.TabIndex = 10;
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.BackColor = System.Drawing.Color.Green;
            this.BtnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCambios.Location = new System.Drawing.Point(229, 344);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(101, 23);
            this.BtnGuardarCambios.TabIndex = 11;
            this.BtnGuardarCambios.Text = "Guardar Cambios";
            this.BtnGuardarCambios.UseVisualStyleBackColor = false;
            this.BtnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(354, 344);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // RolPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 374);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnGuardarCambios);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscarPermisos);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.label1);
            this.Name = "RolPermiso";
            this.Text = "RolPermiso";
            this.Load += new System.EventHandler(this.RolPermiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Button BtnBuscarPermisos;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button btnSalir;
    }
}