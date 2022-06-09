using CapaDatos;
using CapaModelo;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBiblioteca
{
    public partial class NuevoBibliotecario : Form
    {
        LBibliotecario Db = new LBibliotecario();
        DataTable tabla = new DataTable();
        DBibliotecario r = new DBibliotecario();
        public NuevoBibliotecario()
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
                Interaction.MsgBox(ex.Message);
            }
        }

        private void AgregarBibliotecario()
        {
            try
            {
                Db.Nombres = txtnombre.Text;
                Db.Apellidos = txtapellido.Text;
                Db.Direccion = txtdireccion.Text;
                Db.Email = txtemail.Text;
                Db.Telefono = Convert.ToInt32(txttelefono.Text);
                Db.Dni = Convert.ToInt32(txtdni.Text);
                Db.Nro_Carnet = txtnrocarnet.Text;
                Db.Contrasena = txtclave.Text;

                if (DBibliotecario.AgregarBibliotecario(Db))
                    this.Close();
                else
                    Interaction.MsgBox("El Registro no fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void btngenerarCarnet_Click(object sender, EventArgs e)
        {
            GenerarCarnet();
        }

        private void GenerarCarnet()
        {
            try
            {
                DataTable tablacarnet;
                tablacarnet = r.GenerarCarnet();

                string carnet;
                carnet = tablacarnet.Rows[0].ItemArray[0].ToString();
                
                txtnrocarnet.Text = carnet;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
    }
}
