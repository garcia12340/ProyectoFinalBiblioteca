using CapaDatos;
using CapaModelo;
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
    public partial class LibrosDevueltos : Form
    {
        DPrestamo FuncPrestamo = new DPrestamo();
        LPrestamo DatPrestamo = new LPrestamo();
        DataView Busqueda;
        public LibrosDevueltos()
        {
            InitializeComponent();
        }

        private void LibrosDevueltos_Load(object sender, EventArgs e)
        {
            CargarListaPrestamo();
            cboBusqueda.SelectedIndex = 0;
            txtBusqueda.Text = "";
        }

        private void CargarListaPrestamo()
        {
            int CantRegistros;
            try
            {
                Busqueda = FuncPrestamo.MostrarPrestamoCancelado().DefaultView;
                dgvPrestamo.DataSource = FuncPrestamo.MostrarPrestamoCancelado();
                dgvPrestamo.DataSource = Busqueda;

                dgvPrestamo.Columns[6].Visible = false;
                CantRegistros = dgvPrestamo.RowCount;
                lblRegistros.Text = Convert.ToString(CantRegistros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvPrestamo.ClearSelection();
                dgvPrestamo.Columns[0].Width = 50;
                dgvPrestamo.Columns[3].Width = 80;
                dgvPrestamo.Columns[4].Width = 90;
                dgvPrestamo.Columns[5].Width = 80;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Busqueda.RowFilter = cboBusqueda.Text + " like '%" + txtBusqueda.Text + "%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
