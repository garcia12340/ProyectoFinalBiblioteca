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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBiblioteca
{
    public partial class NuevoLector : Form
    {
        LLector DatLector = new LLector();
        public NuevoLector()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool valordecajas;
                valordecajas = true;

                foreach (Control Caja in this.Controls)
                {
                    if ((Caja) is TextBox)
                    {
                        if (String.IsNullOrEmpty(Caja.Text))
                        {
                            valordecajas = false;
                            break;
                        }
                    }
                }

                if (valordecajas)
                    AgregarBibliotecario();
                else
                    Interaction.MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarBibliotecario()
        {
            try
            {
                DatLector.Nombres = txtnombre.Text;
                DatLector.Apellidos = txtapellido.Text;
                DatLector.Direccion = txtdireccion.Text;
                DatLector.Email = txtemail.Text;
                DatLector.Telefono = Convert.ToInt32(txttelefono.Text);

                if (DLector.AgregarLector(DatLector))
                    this.Close();
                else
                    Interaction.MsgBox("El Registro no fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Se valida por ASCII las letras
        private void ValidarLetras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
        }

        private bool validarCorreo(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (validarCorreo(txtemail.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo no es valida debe de tener el formato de nombre@gmail.com o nombre@hotmail," +
                    "Por favor seleccione un correo valido", "Validacion de correo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtemail.SelectAll();
                txtemail.Focus();
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
