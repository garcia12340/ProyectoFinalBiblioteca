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
    public partial class DeudaAutor : Form
    {
        LPrestamo DatPrestamo = new LPrestamo();
        public DeudaAutor()
        {
            InitializeComponent();
        }

        private void DeudaAutor_Load(object sender, EventArgs e)
        {
            CargarListaDeuda();
            Mensaje();
        }

        public void CargarListaDeuda()
        {
            try
            {
                if(String.IsNullOrEmpty(txtbusqueda.Text))
                {
                    dgvLector.DataSource = null;
                    return;
                }

                DatPrestamo.CodLector = Convert.ToInt32(txtbusqueda.Text);
                dgvLector.DataSource = DPrestamo.MostrarPrestamoDeuda(DatPrestamo);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public void Mensaje()
        {
            try
            {
                if (dgvLector.RowCount > 0)
                    lblmensaje.Visible = false;
                else
                    lblmensaje.Visible = true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarListaDeuda();
                Mensaje();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
    }
}
