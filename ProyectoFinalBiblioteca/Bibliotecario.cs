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
    public partial class Bibliotecario : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        DBibliotecario FuncBibliotecario = new DBibliotecario();
        LBibliotecario DatBibliotecario = new LBibliotecario();
        public Bibliotecario()
        {
            InitializeComponent();
        }

        private void Bibliotecario_Load(object sender, EventArgs e)
        {
            CargarListaBibliotecario();
            Botones();
        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)//Alt + 124
            {
                this.Habilitar(true);
                this.BtnNuevo.Enabled = false;
                this.BtnModificar.Enabled = false;
                this.BtnNuevo.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.BtnNuevo.Enabled = true;
                this.BtnModificar.Enabled = false;
                this.BtnEliminar.Enabled = false;
            }
        }

        private void Habilitar(bool valor)
        {
            this.dgvBibliotecario.ReadOnly = !valor;
        }

        public void CargarListaBibliotecario()
        {

            int CantRegistros;
            try
            {
                dgvBibliotecario.DataSource = FuncBibliotecario.MostrarBibliotecarios();
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
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBibliotecario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ModificarBibliotecarios()
        {
            try
            {
                ModificarBibliotecario FormModificar = new ModificarBibliotecario();
                FormModificar.CodBibliotecario = Convert.ToInt32(dgvBibliotecario.CurrentRow.Cells[0].Value);
                FormModificar.txtnombre.Text = Convert.ToString(dgvBibliotecario.CurrentRow.Cells[1].Value);
                FormModificar.txtapellido.Text = Convert.ToString(dgvBibliotecario.CurrentRow.Cells[2].Value);
                FormModificar.txtdireccion.Text = Convert.ToString(dgvBibliotecario.CurrentRow.Cells[3].Value);
                FormModificar.txtemail.Text = Convert.ToString(dgvBibliotecario.CurrentRow.Cells[4].Value);
                FormModificar.txttelefono.Text = Convert.ToString(dgvBibliotecario.CurrentRow.Cells[5].Value);
                FormModificar.txtdni.Text = Convert.ToString(dgvBibliotecario.CurrentRow.Cells[6].Value);
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
                if (dgvBibliotecario.SelectedRows.Count > 0)
                {
                    EliminarBibliotecario();
                    CargarListaBibliotecario();
                }
                else
                    Interaction.MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarBibliotecario()
        {
            try
            {
                DatBibliotecario.CodBibliotecario = Convert.ToInt32(dgvBibliotecario.CurrentRow.Cells[0].Value);
                
                if (Interaction.MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Yes)
                {
                    if (DBibliotecario.EliminarBibliotecario(DatBibliotecario))
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
