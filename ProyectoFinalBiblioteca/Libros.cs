﻿using Microsoft.VisualBasic;
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

        private void CargarListaLibro()
        {
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
    }
}
