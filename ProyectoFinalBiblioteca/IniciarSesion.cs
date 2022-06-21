using CapaDatos;
using MaterialSkin;
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
    public partial class IniciarSesion : MaterialSkin.Controls.MaterialForm
    {
        public IniciarSesion()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            int IdUsuario = DUsuario.LoginUsuario(txtUsuario.Text, txtContraseña.Text);
            if (IdUsuario != 0)
            {
                MDIMaster frm = new MDIMaster(IdUsuario);
                frm.Show();
                this.Hide();
                frm.FormClosing += IniciarSesion_FormClosing;
            }
            else
            {
                MessageBox.Show("No hay conexion con el servidor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show("No se econtraron coincidencias del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El campo de datos del Usuario no puede quedar vacío");
            }
            if (String.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("El campo de datos de la Contraseña del Usuario no puede quedar vacío");
            }
        }

        private void IniciarSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            //txtUsuario.Focus();
            this.Show();
        }

        private void IniciarSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Red900, Primary.Red900, Accent.Blue700, TextShade.WHITE);
        }
    }
}
