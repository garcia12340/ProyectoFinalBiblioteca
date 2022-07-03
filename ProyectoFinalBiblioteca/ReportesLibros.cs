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
    public partial class ReportesLibros : Form
    {
        public string Busqueda;
        public ReportesLibros()
        {
            InitializeComponent();
        }

        private void ReporteLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbbibliotecaDataSet.ReporteLibros' Puede moverla o quitarla según sea necesario.
            
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            this.ReporteLibrosTableAdapter.Fill(this.dbbibliotecaDataSet.ReporteLibros, Busqueda );
            this.reportViewer1.RefreshReport();
        }
    }
             
}
