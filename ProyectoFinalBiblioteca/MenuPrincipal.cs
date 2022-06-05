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
            Inicio azaria = new Inicio();
            azaria.ShowDialog();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Inicio azaria = new Inicio();
            azaria.ShowDialog();
            
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
            MessageBox.Show("¿Desea Salir Del Sistema ? ", "Saliendo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
