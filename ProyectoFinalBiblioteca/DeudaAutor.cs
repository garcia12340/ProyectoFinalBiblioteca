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
        DPrestamo FuncPrestamo = new DPrestamo();
        public DeudaAutor()
        {
            InitializeComponent();
        }

        private void DeudaAutor_Load(object sender, EventArgs e)
        {
            CargarListaDeuda();
            mensaje();
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
                dgvLector.DataSource = FuncPrestamo.MostrarPrestamoDeuda(DatPrestamo);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                dgvLector.ClearSelection();
            }
        }

        public void mensaje()
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
                mensaje();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            //try
            //{
            //    if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar))
            //        e.Handled = false;
            //    else
            //        e.Handled = true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
