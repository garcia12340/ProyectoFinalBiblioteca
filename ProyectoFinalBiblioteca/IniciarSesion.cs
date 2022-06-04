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
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //Se manda a llamar a los get y set
            bool eseditar = true;
            LBibliotecario obibliotecario = new LBibliotecario()
            {
                Nro_Carnet = Convert.ToString(txtuser.Text),
                Contrasena = Convert.ToString(txtclave.Text),
            };
            int respuesta;
            //string msgOk = "";
            //string msgError = "";

            try
            {
                if (txtclave.Text == "")
                {
                    //MessageBox.Show("Complete los datos por favor", "Iniciar Sesion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Interaction.MsgBox("Complete los datos porfavor", MsgBoxStyle.Information, "Mensaje del Sistema");
                    return;
                }

                if (DBibliotecario.AccederBibliotecario(obibliotecario))
                {
                    this.Hide();
                    Interaction.MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje del Sistema");

                    MenuPrincipal n = new MenuPrincipal();
                    n.ShowDialog();
                    //msgOk = "Bienvenido al Sistema";
                    //msgError = "Carnet o contraseña incorrecta";
                }
                else
                    //respuesta = DBibliotecario.AccederBibliotecario(obibliotecario);
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
