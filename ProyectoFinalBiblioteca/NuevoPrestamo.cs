using CapaDatos;
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
    public partial class NuevoPrestamo : Form
    {
        DLibros FuncLibro = new DLibros();
        LLibros DatLibro = new LLibros();

        DLector FuncLector = new DLector();
        LLector DatLector = new LLector();

        DPrestamo FuncPrestamo = new DPrestamo();
        LPrestamo DatPrestamo = new LPrestamo();

        public NuevoPrestamo()
        {
            InitializeComponent();
        }

        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            Cargarstocklibros();
            dtpFecDevolucion.MinDate = DateTime.Now.Date;
        }

        private void Cargarstocklibros()
        {
            try
            {
                dgvLibro.DataSource = FuncLibro.MostrarStockLibros();


                dgvLibro.Columns[0].Width = 50;
                dgvLibro.Columns[3].Width = 70;
                dgvLibro.ClearSelection();
            }


            catch (Exception ex)
            {
                MessageBox.Show("este es el mensaje");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnlector_Click(object sender, EventArgs e)
        {
            VistaLectores m = new VistaLectores();
            m.ShowDialog();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            VistaLibros x = new VistaLibros();
            x.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCodLector.Text) | String.IsNullOrEmpty(txtCodLibro.Text))
                {
                    Interaction.MsgBox("Faltan Completar Datos", MsgBoxStyle.Information, "Mensaje del Sistema");
                    return;
                }

                if (VerificarLibro())
                {
                    Interaction.MsgBox("No hay más libros Disponibles.", MsgBoxStyle.Critical, "Mensaje del Sistema");
                    return;
                }

                if (VerificarLector())
                {
                    if (Interaction.MsgBox("El Lector tiene libros pendientes fuera de fecha." + Constants.vbCrLf + "¿Desea registrar el prestamo de todas maneras?", MsgBoxStyle.YesNo, "Mensaje del Sistema") == MsgBoxResult.Yes)
                    {
                        RegistrarPrestamo();
                        Cargarstocklibros();
                        return;
                    }
                    else
                        return;
                }
                else
                {
                    RegistrarPrestamo();
                    Cargarstocklibros();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public bool VerificarLibro()
        {
            try
            {
                DataTable resultado;
                DatLibro.Codlibro = Convert.ToInt32(txtCodLibro.Text);

                resultado = FuncLibro.VerificarLibro(DatLibro);

                var cantidad = Convert.ToInt32(resultado.Rows[0].ItemArray[0]);


                if (cantidad > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                return true;
            }
        }

        private bool VerificarLector()
        {
            try
            {
                DataTable resultado;
                DatLector.CodLector = Convert.ToInt32(txtCodLector.Text);

                resultado = FuncLector.VerificarLector(DatLector);

                if (resultado.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                return false;
            }
        }

        private void RegistrarPrestamo()
        {
            try
            {
                DatPrestamo.CodLector = Convert.ToInt32(txtCodLector.Text);
                DatPrestamo.CodLibro = Convert.ToInt32(txtCodLibro.Text);
                DatPrestamo.Fec_Devolucion = dtpFecDevolucion.Value.Date;



                if (DPrestamo.AgregarPrestamo(DatPrestamo))
                {
                    Interaction.MsgBox("Registro Fue Agregado", MsgBoxStyle.Information, "Mensaje del Sistema");
                    LimpiarDatos();
                }
                else
                    Interaction.MsgBox("Registro No Fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void LimpiarDatos()
        {
            txtLector.Text = "";
            txtCodLector.Text = "";
            txtLibro.Text = "";
            txtCodLibro.Text = "";
            dgvLibro.ClearSelection();
        }

        private void btndeuda_Click(object sender, EventArgs e)
        {
            try
            {
                DeudaAutor Formulario = new DeudaAutor();
                Formulario.txtbusqueda.Text = this.txtCodLector.Text;
                Formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
