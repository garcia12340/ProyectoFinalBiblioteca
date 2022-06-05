
namespace ProyectoFinalBiblioteca
{
    partial class MenuPrincipal
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
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBInicio = new System.Windows.Forms.ToolStripButton();
            this.TSBibliotecario = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSMINuevoPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMILibrosPrestados = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMILibrosDevueltos = new System.Windows.Forms.ToolStripMenuItem();
            this.TSBlibros = new System.Windows.Forms.ToolStripButton();
            this.TSBLectores = new System.Windows.Forms.ToolStripButton();
            this.lblSalir = new System.Windows.Forms.Label();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Firebrick;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(831, 71);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Sistema de Biblioteca";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBInicio,
            this.TSBibliotecario,
            this.ToolStripButton3,
            this.TSBlibros,
            this.TSBLectores});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 71);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(831, 35);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // TSBInicio
            // 
            this.TSBInicio.Image = global::ProyectoFinalBiblioteca.Properties.Resources.Inicio;
            this.TSBInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBInicio.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.TSBInicio.Name = "TSBInicio";
            this.TSBInicio.Size = new System.Drawing.Size(67, 25);
            this.TSBInicio.Text = "Inicio";
            this.TSBInicio.Click += new System.EventHandler(this.TSBInicio_Click);
            // 
            // TSBibliotecario
            // 
            this.TSBibliotecario.Image = global::ProyectoFinalBiblioteca.Properties.Resources.biblio;
            this.TSBibliotecario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBibliotecario.Margin = new System.Windows.Forms.Padding(5);
            this.TSBibliotecario.Name = "TSBibliotecario";
            this.TSBibliotecario.Size = new System.Drawing.Size(116, 25);
            this.TSBibliotecario.Text = "Bibliotecario";
            this.TSBibliotecario.Click += new System.EventHandler(this.TSBibliotecario_Click);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMINuevoPrestamo,
            this.TSMILibrosPrestados,
            this.TSMILibrosDevueltos});
            this.ToolStripButton3.Image = global::ProyectoFinalBiblioteca.Properties.Resources.transaccion1;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(135, 25);
            this.ToolStripButton3.Text = "Transacciones";
            // 
            // TSMINuevoPrestamo
            // 
            this.TSMINuevoPrestamo.BackColor = System.Drawing.Color.SkyBlue;
            this.TSMINuevoPrestamo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMINuevoPrestamo.Name = "TSMINuevoPrestamo";
            this.TSMINuevoPrestamo.Size = new System.Drawing.Size(176, 22);
            this.TSMINuevoPrestamo.Text = "Nuevo Prestamo";
            // 
            // TSMILibrosPrestados
            // 
            this.TSMILibrosPrestados.BackColor = System.Drawing.Color.SkyBlue;
            this.TSMILibrosPrestados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMILibrosPrestados.Name = "TSMILibrosPrestados";
            this.TSMILibrosPrestados.Size = new System.Drawing.Size(176, 22);
            this.TSMILibrosPrestados.Text = "Libros Prestados";
            // 
            // TSMILibrosDevueltos
            // 
            this.TSMILibrosDevueltos.BackColor = System.Drawing.Color.SkyBlue;
            this.TSMILibrosDevueltos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMILibrosDevueltos.Name = "TSMILibrosDevueltos";
            this.TSMILibrosDevueltos.Size = new System.Drawing.Size(176, 22);
            this.TSMILibrosDevueltos.Text = "Libros Devueltos";
            // 
            // TSBlibros
            // 
            this.TSBlibros.Image = global::ProyectoFinalBiblioteca.Properties.Resources.libros;
            this.TSBlibros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBlibros.Margin = new System.Windows.Forms.Padding(5);
            this.TSBlibros.Name = "TSBlibros";
            this.TSBlibros.Size = new System.Drawing.Size(73, 25);
            this.TSBlibros.Text = "Libros";
            this.TSBlibros.Click += new System.EventHandler(this.TSBlibros_Click);
            // 
            // TSBLectores
            // 
            this.TSBLectores.Image = global::ProyectoFinalBiblioteca.Properties.Resources.lector;
            this.TSBLectores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBLectores.Margin = new System.Windows.Forms.Padding(5);
            this.TSBLectores.Name = "TSBLectores";
            this.TSBLectores.Size = new System.Drawing.Size(88, 25);
            this.TSBLectores.Text = "Lectores";
            this.TSBLectores.Click += new System.EventHandler(this.TSBLectores_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.Firebrick;
            this.lblSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.White;
            this.lblSalir.Location = new System.Drawing.Point(791, 9);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(40, 20);
            this.lblSalir.TabIndex = 6;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 565);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Label1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton TSBInicio;
        internal System.Windows.Forms.ToolStripButton TSBibliotecario;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripMenuItem TSMINuevoPrestamo;
        internal System.Windows.Forms.ToolStripMenuItem TSMILibrosPrestados;
        internal System.Windows.Forms.ToolStripMenuItem TSMILibrosDevueltos;
        internal System.Windows.Forms.ToolStripButton TSBlibros;
        internal System.Windows.Forms.ToolStripButton TSBLectores;
        internal System.Windows.Forms.Label lblSalir;
    }
}