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
    public partial class Lector : Form
    {
        DLector FuncLector = new DLector();
        LLector DatLector = new LLector();
        public Lector()
        {
            InitializeComponent();
        }

        private void Lector_Load(object sender, EventArgs e)
        {
            CargarListaLector();
        }

        public void CargarListaLector()
        {
            int CantRegistros;
            try
            {
                dgvLector.DataSource = FuncLector.MostrarLector();
                dgvLector.Columns[0].Visible = false;
                CantRegistros = dgvLector.RowCount;
                lblRegistros.Text = Convert.ToString(CantRegistros);
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoLector FormAgregar = new NuevoLector();
            FormAgregar.ShowDialog();
            CargarListaLector();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLector.SelectedRows.Count > 0)
                {
                    ModificarLectores();
                    CargarListaLector();
                }
                else
                    Interaction.MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public void ModificarLectores()
        {
            try
            {
                ModificarLector FormModificar = new ModificarLector();
                FormModificar.CodLector = Convert.ToInt32(this.dgvLector.CurrentRow.Cells[0].Value);
                FormModificar.txtnombre.Text = Convert.ToString(this.dgvLector.CurrentRow.Cells[1].Value);
                FormModificar.txtapellido.Text = Convert.ToString(this.dgvLector.CurrentRow.Cells[2].Value);
                FormModificar.txtdireccion.Text = Convert.ToString(this.dgvLector.CurrentRow.Cells[3].Value);
                FormModificar.txtemail.Text = Convert.ToString(this.dgvLector.CurrentRow.Cells[4].Value);
                FormModificar.txttelefono.Text = Convert.ToString(this.dgvLector.CurrentRow.Cells[5].Value);
                FormModificar.ShowDialog();
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
                if (dgvLector.SelectedRows.Count > 0)
                {
                    EliminarLector();
                    CargarListaLector();
                }
                else
                    Interaction.MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public void EliminarLector()
        {
            try
            {
                DatLector.CodLector = Convert.ToInt32(dgvLector.CurrentRow.Cells[0].Value);

                if (Interaction.MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Ok)
                {
                    if (DLector.EliminarLector(DatLector))
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
    }
}
