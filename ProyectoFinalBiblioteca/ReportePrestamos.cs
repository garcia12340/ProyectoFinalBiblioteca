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
    public partial class ReportePrestamos : Form
    {
        public string Busqueda;
        public ReportePrestamos()
        {
            InitializeComponent();
        }

        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbbibliotecaDataSet1.ReportePrestamos' Puede moverla o quitarla según sea necesario.
            this.ReportePrestamosTableAdapter.Fill(this.dbbibliotecaDataSet1.ReportePrestamos, Busqueda);
            this.ReportViewer1.RefreshReport();

        }
    }
}
