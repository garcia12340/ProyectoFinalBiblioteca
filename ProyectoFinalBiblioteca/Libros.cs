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
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

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
                ReporteLibros z = new ReporteLibros();
                z.Busqueda = Convert.ToString(txtBusqueda.Text);
                z.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
