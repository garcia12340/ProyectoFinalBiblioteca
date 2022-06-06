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
    public partial class Editorial : Form
    {
        LEditorial DatEditorial = new LEditorial();
        public Editorial()
        {
            InitializeComponent();
        }

        private void Editorial_Load(object sender, EventArgs e)
        {
            CargarListaEditorial();
        }

        public void CargarListaEditorial()
        {
            int CantRegistros;
            try
            {
                dgvEditorial.DataSource = DEditorial.MostrarEditorial();

                CantRegistros = dgvEditorial.RowCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al : " + ex.Message);
            }
            finally
            {
                dgvEditorial.ClearSelection();
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
                    AgregarEditorial();
                    CargarListaEditorial();
                    txtNEditorial.Clear();
                }
                else
                {
                    Interaction.MsgBox("Ingrese una Editorial", MsgBoxStyle.Information, "Mensaje del Sistema");
                    txtNEditorial.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AgregarEditorial()
        {
            try
            {
                DatEditorial.Editorial = txtNEditorial.Text;


                if (DEditorial.AgregarEditorial(DatEditorial))
                    Interaction.MsgBox("El Registro fue Agregado", MsgBoxStyle.Information, "Mensaje del Sistema");
                else
                    Interaction.MsgBox("El Registro no fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
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
                    ModificarEditorial();
                    CargarListaEditorial();
                    txtMCodigo.Clear();
                    txtMEditorial.Clear();
                }
                else
                {
                    Interaction.MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema");
                    if (String.IsNullOrEmpty(txtMCodigo.Text))
                        txtMCodigo.Focus();
                    else
                        txtMEditorial.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificarEditorial()
        {
            try
            {
                DatEditorial.CodEditorial = Convert.ToInt32(txtMCodigo.Text);
                DatEditorial.Editorial = txtMEditorial.Text;

                if (DEditorial.ModificarEditorial(DatEditorial))
                    Interaction.MsgBox("El Registro fue Modificado", MsgBoxStyle.Information, "Mensaje del Sistema");
                else
                    Interaction.MsgBox("El Registro no fue Modificado", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
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
                    EliminarEditorial();
                    CargarListaEditorial();
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
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarEditorial()
        {
            try
            {
                DatEditorial.CodEditorial = Convert.ToInt32(txtECodigo.Text);

                if (Interaction.MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Yes)
                {
                    if (DEditorial.EliminarEditorial(DatEditorial))
                        Interaction.MsgBox("Registro eliminado Correctamente", MsgBoxStyle.Information, "Mensaje del Sistema");
                    else
                        Interaction.MsgBox("No se pudo eliminar el Registro", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
                }
                else
                    return;
            }

            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void dgvEditorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEditorial.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvEditorial.SelectedRows[0];
                int index = currentRow.Index;

                txtMCodigo.Text = dgvEditorial.Rows[index].Cells["CodEditorial"].Value.ToString();
                txtMEditorial.Text = dgvEditorial.Rows[index].Cells["Editorial"].Value.ToString();
                txtECodigo.Text = dgvEditorial.Rows[index].Cells["CodEditorial"].Value.ToString();
            }
        }
    }
}
