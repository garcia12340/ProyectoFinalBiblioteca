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
    public partial class VistaLectores : Form
    {
        public VistaLectores()
        {
            InitializeComponent();
        }

        private void VistaLectores_Load(object sender, EventArgs e)
        {
            CargarListaLector();
        }

        private void CargarListaLector()
        {
            try
            {
                dgvLector.DataSource = DLector.MostrarLector();
                dgvLector.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvLector.ClearSelection();
            }
        }

        private void dgvLector_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
