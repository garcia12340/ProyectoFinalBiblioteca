﻿using CapaDatos;
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
    public partial class LibrosPrestados : Form
    {
        private DataView Busqueda = new DataView();
        DPrestamo FuncPrestamo = new DPrestamo();
        LPrestamo DatPrestamo = new LPrestamo();
        public LibrosPrestados()
        {
            InitializeComponent();
        }

        private void LibrosPrestados_Load(object sender, EventArgs e)
        {
            CargarListaPrestamo();
            cboBusqueda.SelectedIndex = 0;
            txtBusqueda.Text = "";
        }

        private void CargarListaPrestamo()
        {
            //Ayuda Vato xd
            int CantRegistros;
            try
            {
                Busqueda = FuncPrestamo.MostrarPrestamo().DefaultView;
                dgvPrestamo.DataSource = FuncPrestamo.MostrarPrestamo();
                dgvPrestamo.DataSource = Busqueda;

                dgvPrestamo.Columns[5].Visible = false;
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
                dgvPrestamo.Columns[6].Width = 80;
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

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrestamo.SelectedRows.Count > 0)
                {
                    RetornarLibro();
                    CargarListaPrestamo();
                    dgvPrestamo.ClearSelection();
                }
                else
                    Interaction.MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RetornarLibro()
        {
            try
            {
                DatPrestamo.CodPrestamo = Convert.ToInt32(dgvPrestamo.CurrentRow.Cells[0].Value.ToString());

                if (Interaction.MsgBox("¿Desea retornar este libro?",MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Yes)
                {
                    if (DPrestamo.ModificarLibro(DatPrestamo))
                        Interaction.MsgBox("El libro ha sido devuelto exitosamente.", MsgBoxStyle.Information, "Mensaje del Sistema");
                    else
                        Interaction.MsgBox("La devolucón no se pudó realizar.", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ReportePrestamos z = new ReportePrestamos();
                z.Busqueda = Convert.ToString(txtBusqueda.Text);
                z.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
