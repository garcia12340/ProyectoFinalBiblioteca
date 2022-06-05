using CapaDatos;
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
                dgvLector.DataSource = DLector.MostrarLector();
                //dgvLector.Columns(0).Visible = false;
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

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLector.SelectedRows.Count > 0)
                {
                    ModificarLector();
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

        public void ModificarLector()
        {
            //try
            //{
            //    FMLector FormModificar = new FMLector();
            //    FormModificar.CodLector = dgvLector.SelectedCells.Item(0).Value;
            //    FormModificar.txtnombre.Text = dgvLector.SelectedCells.Item(1).Value;
            //    FormModificar.txtapellido.Text = dgvLector.SelectedCells.Item(2).Value;
            //    FormModificar.txtdireccion.Text = dgvLector.SelectedCells.Item(3).Value;
            //    FormModificar.txtemail.Text = dgvLector.SelectedCells.Item(4).Value;
            //    FormModificar.txttelefono.Text = dgvLector.SelectedCells.Item(5).Value;
            //    FormModificar.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    Interaction.MsgBox(ex.Message);
            //}
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
            //try
            //{
            //    DatLector._CodLector = dgvLector.SelectedCells.Item(0).Value;

            //    if (Interaction.MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Yes)
            //    {
            //        if (FuncLector.EliminarLector(DatLector))
            //            Interaction.MsgBox("Registro eliminado Correctamente", MsgBoxStyle.Information, "Mensaje del Sistema");
            //        else
            //            Interaction.MsgBox("No se pudo eliminar el Registro", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            //    }
            //    else
            //        return;
            //}

            //catch (Exception ex)
            //{
            //    Interaction.MsgBox(ex.Message);
            //}
        }
    }
}
