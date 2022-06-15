
namespace ProyectoFinalBiblioteca
{
    partial class VistaLectores
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
            this.Label1.Size = new System.Drawing.Size(642, 23);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Doble Click sobre el Lector para Elegirlo";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DarkCyan;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.Location = new System.Drawing.Point(6, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(634, 275);
            this.Label2.TabIndex = 15;
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
            this.dgvLector.Location = new System.Drawing.Point(9, 33);
            this.dgvLector.MultiSelect = false;
            this.dgvLector.Name = "dgvLector";
            this.dgvLector.ReadOnly = true;
            this.dgvLector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLector.Size = new System.Drawing.Size(628, 269);
            this.dgvLector.TabIndex = 16;
            this.dgvLector.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLector_CellDoubleClick);
            // 
            // VistaLectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 304);
            this.Controls.Add(this.dgvLector);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "VistaLectores";
            this.Text = "VistaLectores";
            this.Load += new System.EventHandler(this.VistaLectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dgvLector;
    }
}