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
    public partial class Libros : Form
    {
        //DataView Busqueda = new DataView();
        private DataView Busqueda = new DataView();
        DLibros FuncLibro = new DLibros();
        LLibros DatLibros = new LLibros();
        public Libros()
        {
            InitializeComponent();
        }
       
        private void Libros_Load(object sender, EventArgs e)
        {
            CargarListaLibro();
        }
        private void btnAutor_Click(object sender, EventArgs e)
        {
            Autor FAutores = new Autor();
            FAutores.ShowDialog();
        }
        private void btnGenero_Click(object sender, EventArgs e)
        {
            Genero FAutores = new Genero();
            FAutores.ShowDialog();
        }
        private void btnEditorial_Click(object sender, EventArgs e)
        {
            Editorial FAutores = new Editorial();
            FAutores.ShowDialog();
        }

        public void CargarListaLibro()
        {
            //Ayuda mae xd
            int CantRegistros;
            try
            {
                Busqueda = FuncLibro.MostrarLibros().DefaultView;
                dgvLibro.DataSource = FuncLibro.MostrarLibros();
                dgvLibro.DataSource = Busqueda;

                dgvLibro.Columns[0].Visible = false;
                dgvLibro.Columns[2].Visible = false;
                dgvLibro.Columns[4].Visible = false;
                dgvLibro.Columns[6].Visible = false;

                CantRegistros = dgvLibro.RowCount;
                lblRegistros.Text = Convert.ToString(CantRegistros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvLibro.ClearSelection();
                cboBusqueda.SelectedIndex = 0;
                dgvLibro.Columns[8].Width = 60;
                dgvLibro.Columns[9].Width = 50;
                dgvLibro.Columns[10].Width = 40;
                dgvLibro.Columns[11].Width = 65;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoLibro z = new NuevoLibro();
            z.ShowDialog();
            CargarListaLibro();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLibro.SelectedRows.Count > 0)
                {
                    ModificarLibro();
                    CargarListaLibro();
                }
                else
                    Interaction.MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarLibro()
        {
            try
            {
                ModificarLibro FormModificar = new ModificarLibro();
                FormModificar.CodLibro = Convert.ToInt32(dgvLibro.CurrentRow.Cells[0].Value);
                FormModificar.txtTitulo.Text = Convert.ToString(dgvLibro.CurrentRow.Cells[1].Value);
                FormModificar.CodAutor = Convert.ToInt32(dgvLibro.CurrentRow.Cells[2].Value);
                FormModificar.CodGenero = Convert.ToInt32(dgvLibro.CurrentRow.Cells[4].Value);
                FormModificar.CodEditorial = Convert.ToInt32(dgvLibro.CurrentRow.Cells[6].Value);

                FormModificar.txtUbicacion.Text = Convert.ToString(dgvLibro.CurrentRow.Cells[8].Value);
                FormModificar.txtCantidad.Text = Convert.ToString(dgvLibro.CurrentRow.Cells[9].Value);
                FormModificar.txtEdicion.Text = Convert.ToString(dgvLibro.CurrentRow.Cells[10].Value);
                FormModificar.txtAñoEdicion.Text = Convert.ToString(dgvLibro.CurrentRow.Cells[11].Value);

                FormModificar.ShowDialog();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLibro.SelectedRows.Count > 0)
                {
                    EliminarLibro();
                    CargarListaLibro();
                }
                else
                    Interaction.MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarLibro()
        {
            try
            {
                DatLibros.Codlibro = Convert.ToInt32(dgvLibro.CurrentRow.Cells[0].Value);

                if (Interaction.MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Yes)
                {
                    if (DLibros.EliminarLibro(DatLibros))
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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Busqueda.RowFilter = cboBusqueda.Text + " like '" + txtBusqueda.Text + "%'";
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ReportesLibros z = new ReportesLibros();
                z.Busqueda = Convert.ToString(txtBusqueda.Text);
                z.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
