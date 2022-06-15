using CapaDatos;
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
    public partial class VistaLibros : Form
    {
        DLibros FuncLibro = new DLibros();
        DataView Busqueda = new DataView();
        public VistaLibros()
        {
            InitializeComponent();
        }

        private void VistaLibros_Load(object sender, EventArgs e)
        {
            CargarListaLibro();
        }

        private void CargarListaLibro()
        {
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

        private void dgvLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NuevoPrestamo w = new NuevoPrestamo();
            try
            {
                string libro;
                string codigo;
                libro = this.dgvLibro.CurrentRow.Cells[1].Value.ToString();
                codigo = this.dgvLibro.CurrentRow.Cells[0].Value.ToString();

                w.txtLibro.Text = libro;
                w.txtCodLibro.Text = codigo;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            w.Show();
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
    }
}
