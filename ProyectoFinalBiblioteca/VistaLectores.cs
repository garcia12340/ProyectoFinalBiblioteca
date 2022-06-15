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
    public partial class VistaLectores : Form
    {
        DLector FuncLector = new DLector();
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
                dgvLector.DataSource = FuncLector.MostrarLector();
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
            NuevoPrestamo a = new NuevoPrestamo();
            //if (e.RowIndex == -1) return;
            //DataGridViewRow row = dgvLector.CurrentRow;
            //if (row != null)
            //{
            //    NuevoPrestamo a = new NuevoPrestamo();
            //    a.txtLector.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            //    a.txtCodLector.Text = row.Cells[0].Value.ToString();
            //    a.ShowDialog();
            //}
            try
            {
                string lector;
                string codigo;
                lector = this.dgvLector.CurrentRow.Cells[1].Value + " " + this.dgvLector.CurrentRow.Cells[2].Value;
                codigo = this.dgvLector.CurrentRow.Cells[0].Value.ToString();


                a.txtLector.Text = lector;
                a.txtCodLector.Text = codigo;
                this.Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }

            a.Show();
        }
    }
}
