using CapaDatos;
using CapaModelo;
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
    public partial class IniciarSesion : Form
    {
        LBibliotecario lb1 = new LBibliotecario();
        DBibliotecario db1 = new DBibliotecario();
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtclave.Text == "")
                {
                    Interaction.MsgBox("Complete los datos porfavor", MsgBoxStyle.Information, "Mensaje del Sistema");
                    return;
                }

                lb1.Nro_Carnet = Convert.ToString(txtuser.Text);
                lb1.Contrasena = Convert.ToString(txtclave.Text);

                if (DBibliotecario.AccederBibliotecario(lb1))
                {
                    this.Hide();
                    Interaction.MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje del Sistema");
                    MenuPrincipal n = new MenuPrincipal();
                    n.ShowDialog();
                }
                else
                    Interaction.MsgBox("Carnet o contraseña incorrecta", MsgBoxStyle.Critical, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
            }
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtuser.Text = "";
            txtclave.Text = "";
            txtuser.Focus();
            this.Show();
        }
    }
}
