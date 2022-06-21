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
            try
            {
                NuevoPrestamo Frm2 = new NuevoPrestamo();
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "NuevoPrestamo")
                    {
                        Frm2 = (NuevoPrestamo)form;
                        Frm2.txtLector.Text = this.dgvLector.CurrentRow.Cells[1].Value.ToString() + " " + this.dgvLector.CurrentRow.Cells[2].Value.ToString();
                        Frm2.txtCodLector.Text = this.dgvLector.CurrentRow.Cells[0].Value.ToString();

                        this.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
