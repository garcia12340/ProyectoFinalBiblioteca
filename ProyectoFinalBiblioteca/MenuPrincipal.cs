using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBiblioteca
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void TSBInicio_Click(object sender, EventArgs e)
        {
            //Inicio azaria = new Inicio();
            //azaria.Show();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //Inicio1 azaria = new Inicio1();
            //azaria.Show();

        }

        private void TSBibliotecario_Click(object sender, EventArgs e)
        {
            Bibliotecario a = new Bibliotecario();
            //Bibliotecario.CargarListaBibliotecario();
            a.ShowDialog();
        }

        private void TSBLectores_Click(object sender, EventArgs e)
        {
            Lector c = new Lector();
            c.ShowDialog();
        }

        private void TSBlibros_Click(object sender, EventArgs e)
        {
            Libros x = new Libros();
            x.ShowDialog();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("¿Desea Salir del Sistema?", MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Yes)
                Application.Exit();
            else
                return;
        }
        private void TSMINuevoPrestamo_Click(object sender, EventArgs e)
        {
            NuevoPrestamo m = new NuevoPrestamo();
            //NuevoPrestamo.Cargarstocklibros();
            //NuevoPrestamo.txtLector.Clear();
            //NuevoPrestamo.txtLibro.Clear();
            //NuevoPrestamo.txtCodLector.Clear();
            //NuevoPrestamo.txtCodLibro.Clear();
            m.ShowDialog();
        }

        private void TSMILibrosPrestados_Click(object sender, EventArgs e)
        {
            LibrosPrestados d = new LibrosPrestados();
            //LibrosPrestados.CargarListaPrestamo();
            //LibrosPrestados.txtBusqueda.Clear();
            d.ShowDialog();
        }

        private void TSMILibrosDevueltos_Click(object sender, EventArgs e)
        {
            LibrosDevueltos a = new LibrosDevueltos();
            //LibrosDevueltos.CargarListaPrestamo();
            //LibrosDevueltos.txtBusqueda.Clear();
            a.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
