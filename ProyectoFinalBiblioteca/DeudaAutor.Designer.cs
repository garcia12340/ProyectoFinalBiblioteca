
namespace ProyectoFinalBiblioteca
{
    partial class DeudaAutor
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
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.dgvLector = new System.Windows.Forms.DataGridView();
            this.lblmensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLector)).BeginInit();
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
            this.Label1.Size = new System.Drawing.Size(640, 35);
            this.Label1.TabIndex = 16;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.DarkCyan;
            this.Label4.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(158, -2);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(267, 28);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Lista de prestamos fuera de fecha";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.DarkCyan;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(459, 11);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(93, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Código del Lector:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(558, 8);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(70, 20);
            this.txtbusqueda.TabIndex = 22;
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
            this.dgvLector.Location = new System.Drawing.Point(6, 41);
            this.dgvLector.MultiSelect = false;
            this.dgvLector.Name = "dgvLector";
            this.dgvLector.ReadOnly = true;
            this.dgvLector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLector.Size = new System.Drawing.Size(628, 140);
            this.dgvLector.TabIndex = 23;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(232, 97);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(183, 24);
            this.lblmensaje.TabIndex = 24;
            this.lblmensaje.Text = "No hay Resultados...";
            // 
            // DeudaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 189);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.dgvLector);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Name = "DeudaAutor";
            this.Text = "DeudaAutor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtbusqueda;
        internal System.Windows.Forms.DataGridView dgvLector;
        internal System.Windows.Forms.Label lblmensaje;
    }
}