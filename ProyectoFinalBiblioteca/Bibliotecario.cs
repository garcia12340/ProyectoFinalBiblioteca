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
    public partial class Bibliotecario : Form
    {
        public Bibliotecario()
        {
            InitializeComponent();
        }

        private void Bibliotecario_Load(object sender, EventArgs e)
        {
            CargarListaBibliotecario();
        }

        public void CargarListaBibliotecario()
        {

            int CantRegistros;
            try
            {
                dgvBibliotecario.DataSource = DBibliotecario.MostrarBibliotecarios();
                //dgvBibliotecario.SelectedColumns.Visible = true;
                CantRegistros = dgvBibliotecario.RowCount;
                lblRegistros.Text = Convert.ToString(CantRegistros);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                dgvBibliotecario.ClearSelection();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoBibliotecario x = new NuevoBibliotecario();
            x.ShowDialog();
            CargarListaBibliotecario();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //ModificarBibliotecario c = new ModificarBibliotecario();
            //c.ShowDialog();
            //CargarListaBibliotecario();
            try
            {
                if (dgvBibliotecario.SelectedRows.Count > 0)
                {
                    ModificarBibliotecarios();
                    CargarListaBibliotecario();
                }
                else
                    Interaction.MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void dgvBibliotecario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(dgvBibliotecario.SelectedRows.Count > 0)
            //{
            //    ModificarBibliotecario FormModificar = new ModificarBibliotecario();

            //    DataGridViewRow currentRow = dgvBibliotecario.SelectedRows[0];
            //    int index = currentRow.Index;

            //    FormModificar.CodBibliotecario = dgvBibliotecario.Rows[index].Cells["CodBibliotecario"].Value.ToString();
            //    FormModificar.txtnombre.Text = dgvBibliotecario.Rows[index].Cells["Nombres"].Value.ToString();
            //    FormModificar.txtapellido.Text = dgvBibliotecario.Rows[index].Cells["Apellidos"].Value.ToString();
            //    FormModificar.txtdireccion.Text = dgvBibliotecario.Rows[index].Cells["Direccion"].Value.ToString();
            //    FormModificar.txtemail.Text = dgvBibliotecario.Rows[index].Cells["Email"].Value.ToString();
            //    FormModificar.txttelefono.Text = dgvBibliotecario.Rows[index].Cells["Telefono"].Value.ToString();
            //    FormModificar.txtdni.Text = dgvBibliotecario.Rows[index].Cells["Dni"].Value.ToString();
            //}
        }

        private void ModificarBibliotecarios()
        {
            try
            {
                ModificarBibliotecario FormModificar = new ModificarBibliotecario();
                FormModificar.CodBibliotecario = dgvBibliotecario.SelectedCells.Count;
                //FormModificar.txtnombre.Text = dgvBibliotecario.SelectedCells.IsReadOnly[""].Value();
                //FormModificar.txtapellido.Text = dgvBibliotecario.SelectedCells.Item(2).Value;
                //FormModificar.txtdireccion.Text = dgvBibliotecario.SelectedCells.Item(3).Value;
                //FormModificar.txtemail.Text = dgvBibliotecario.SelectedCells.Item(4).Value;
                //FormModificar.txttelefono.Text = dgvBibliotecario.SelectedCells.Item(5).Value;
                //FormModificar.txtdni.Text = dgvBibliotecario.SelectedCells.Item(6).Value;
                FormModificar.ShowDialog();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
    }
}
