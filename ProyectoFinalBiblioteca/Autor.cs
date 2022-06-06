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
    public partial class Autor : Form
    {
        LAutor DatAutor = new LAutor();
        public Autor()
        {
            InitializeComponent();
        }

        private void Autor_Load(object sender, EventArgs e)
        {
            CargarListaAutor();
        }
        public void CargarListaAutor()
        {
            int CantRegistros;
            try
            {
                dgvAutor.DataSource = DAutor.MostrarAutor();

                CantRegistros = dgvAutor.RowCount;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                dgvAutor.ClearSelection();
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
                    AgregarLector();
                    CargarListaAutor();
                    txtNAutor.Clear();
                }
                else
                {
                    Interaction.MsgBox("Ingrese un Autor", MsgBoxStyle.Information, "Mensaje del Sistema");
                    txtNAutor.Focus();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public void AgregarLector()
        {
            try
            {
                DatAutor.Autor = txtNAutor.Text;

                if (DAutor.AgregarAutor(DatAutor))
                    Interaction.MsgBox("El Registro fue Agregado", MsgBoxStyle.Information, "Mensaje del Sistema");
                else
                    Interaction.MsgBox("El Registro no fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
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
                    ModificarLector();
                    CargarListaAutor();
                    txtMCodigo.Clear();
                    txtMAutor.Clear();
                }
                else
                {
                    Interaction.MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema");
                    if (String.IsNullOrEmpty(txtMCodigo.Text))
                        txtMCodigo.Focus();
                    else
                        txtMAutor.Focus();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public void ModificarLector()
        {
            try
            {
                DatAutor.CodAutor = Convert.ToInt32(txtMCodigo.Text);
                DatAutor.Autor = txtMAutor.Text;



                if (DAutor.ModificarAutor(DatAutor))
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
                    EliminarAutor();
                    CargarListaAutor();
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

        public void EliminarAutor()
        {
            try
            {
                DatAutor.CodAutor = Convert.ToInt32(txtECodigo.Text);
                if (Interaction.MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Yes)
                {
                    if (DAutor.EliminarAutor(DatAutor))
                        Interaction.MsgBox("Registro eliminado Correctamente", MsgBoxStyle.Information, "Mensaje del Sistema");
                    else
                        Interaction.MsgBox("No se pudo eliminar el Registro", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message);
            }
        }

        private void dgvAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAutor.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvAutor.SelectedRows[0];
                int index = currentRow.Index;

                txtMCodigo.Text = dgvAutor.Rows[index].Cells["CodAutor"].Value.ToString();
                txtMAutor.Text = dgvAutor.Rows[index].Cells["Autor"].Value.ToString();
                txtECodigo.Text = dgvAutor.Rows[index].Cells["CodAutor"].Value.ToString();
            }
            //txtMCodigo.Text = dgvAutor.SelectedCells.Item(0).Value;
            //txtECodigo.Text = dgvAutor.SelectedCells.Item(1).Value;

            //txt.Text = dgvAutor.SelectedCells.Item(0).Value;
        }
    }
}
