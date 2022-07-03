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
    public partial class Genero : Form
    {
        DGenero FunGenero = new DGenero();
        LGenero DatGenero = new LGenero();
        public Genero()
        {
            InitializeComponent();
        }

        private void Genero_Load(object sender, EventArgs e)
        {
            CargarListaGenero();
        }

        public void CargarListaGenero()
        {
            int CantRegistros;
            try
            {
                dgvGenero.DataSource = FunGenero.MostrarGenero();

                CantRegistros = dgvGenero.RowCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvGenero.ClearSelection();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool valordecajas;
                valordecajas = true;

                foreach (Control Caja in GroupBox2.Controls)
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
                {
                    AgregarGenero();
                    CargarListaGenero();
                    txtNGenero.Clear();
                }
                else
                {
                    Interaction.MsgBox("Ingrese un Género Literario", MsgBoxStyle.Information, "Mensaje del Sistema");
                    txtNGenero.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AgregarGenero()
        {
            try
            {
                DatGenero.Genero = txtNGenero.Text;


                if (DGenero.AgregarGenero(DatGenero))
                    Interaction.MsgBox("El Registro fue Agregado", MsgBoxStyle.Information, "Mensaje del Sistema");
                else
                    Interaction.MsgBox("El Registro no fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                bool valordecajas;
                valordecajas = true;

                foreach (Control Caja in GroupBox3.Controls)
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
                {
                    ModificarGenero();
                    CargarListaGenero();
                    txtMCodigo.Clear();
                    txtMGenero.Clear();
                }
                else
                {
                    Interaction.MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema");
                    if (String.IsNullOrEmpty(txtMCodigo.Text))
                        txtMCodigo.Focus();
                    else
                        txtMGenero.Focus();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public void ModificarGenero()
        {
            try
            {
                DatGenero.CodGenero = Convert.ToInt32(txtMCodigo.Text);
                DatGenero.Genero = txtMGenero.Text;



                if (DGenero.ModificarGenero(DatGenero))
                    Interaction.MsgBox("El Registro fue Modificado", MsgBoxStyle.Information, "Mensaje del Sistema");
                else
                    Interaction.MsgBox("El Registro no fue Modificado", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool valordecajas;
                valordecajas = true;

                foreach (Control Caja in GroupBox4.Controls)
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
                {
                    EliminarGenero();
                    CargarListaGenero();
                    txtECodigo.Clear();
                }
                else
                {
                    Interaction.MsgBox("Ingrese un Codigo", MsgBoxStyle.Information, "Mensaje del Sistema");
                    txtECodigo.Focus();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public void EliminarGenero()
        {
            try
            {
                DatGenero.CodGenero = Convert.ToInt32(txtECodigo.Text);

                if (Interaction.MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Yes)
                {
                    if (DGenero.EliminarGenero(DatGenero))
                        Interaction.MsgBox("Registro eliminado Correctamente", MsgBoxStyle.Information, "Mensaje del Sistema");
                    else
                        Interaction.MsgBox("No se pudo eliminar el Registro", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
                }
                else
                    return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvGenero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMCodigo.Text = Convert.ToString(dgvGenero.CurrentRow.Cells[0].Value);
            txtMGenero.Text = Convert.ToString(dgvGenero.CurrentRow.Cells[1].Value);
            txtECodigo.Text = Convert.ToString(dgvGenero.CurrentRow.Cells[0].Value);
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

        //Se valida por ASCII los numeros
        private void ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
        }

        private void txtMGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(sender, e);
        }

        private void txtMCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(sender, e);
        }

        private void txtECodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(sender, e);
        }
    }
}
