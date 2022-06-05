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
            //{
                int CantRegistros;
                try
                {
                    dgvBibliotecario.DataSource = DBibliotecario.MostrarBibliotecarios();
                    //dgvBibliotecario.SelectedColumns(0).Visible = false;
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
            //}
        }
    }
}
