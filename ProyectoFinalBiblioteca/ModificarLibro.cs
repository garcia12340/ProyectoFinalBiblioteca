using CapaDatos;
using CapaModelo;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBiblioteca
{
    public partial class ModificarLibro : Form
    {
        private DConexion dconexion = new DConexion();

        private DLibros FuncLibro = new DLibros();
        private LLibros DatLibro = new LLibros();
        private DAutor FuncAutor = new DAutor();
        private DGenero FuncGenero = new DGenero();
        private DEditorial FuncEditorial = new DEditorial();

        public int CodLibro;
        public int CodAutor;
        public int CodGenero;
        public int CodEditorial;
        public ModificarLibro()
        {
            InitializeComponent();
        }

        private void ModificarLibro_Load(object sender, EventArgs e)
        {
            CargarAutor();
            CargarGenero();
            CargarEditorial();
        }

        //Este metodo sirve para cargar los autores que existe en la bd y se cargan mediante un ComboBox
        private void CargarAutor()
        {
            try
            {
                cboAutor.DataSource = FuncAutor.MostrarAutor();

                cboAutor.DisplayMember = "Autor";
                cboAutor.ValueMember = "Codigo";

                if (CodAutor != 0)
                    cboAutor.SelectedValue = CodAutor;
                CodAutor = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarGenero()
        {
            try
            {
                cboGenero.DataSource = FuncGenero.MostrarGenero();

                cboGenero.DisplayMember = "Genero";
                cboGenero.ValueMember = "Codigo";

                if (CodGenero != 0)
                    cboGenero.SelectedValue = CodGenero;
                CodGenero = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarEditorial()
        {
            try
            {
                cboEditorial.DataSource = FuncEditorial.MostrarEditorial();

                cboEditorial.DisplayMember = "Editorial";
                cboEditorial.ValueMember = "Codigo";

                if (CodEditorial != 0)
                    cboEditorial.SelectedValue = CodEditorial;
                CodEditorial = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bool valordecajas;
                valordecajas = true;

                foreach (Control Caja in this.Controls)
                {
                    if ((Caja) is TextBox)
                    {
                        if (String.IsNullOrEmpty(Caja.Text))
                        {
                            valordecajas = false;
                            break;
                        }
                    }
                }

                if (valordecajas)
                    ModificarLibros();
                else
                    Interaction.MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarLibros()
        {
            try
            {
                int CantidadPrestada;
                int CantidadNueva;
                int NuevoSotck;
                DatLibro.Codlibro = CodLibro;
                DatLibro.Titulo = txtTitulo.Text;
                DatLibro.CodAutor = Convert.ToInt32(cboAutor.SelectedValue.ToString());
                DatLibro.CodGenero = Convert.ToInt32(cboGenero.SelectedValue.ToString());
                DatLibro.CodEditorial = Convert.ToInt32(cboEditorial.SelectedValue.ToString());
                DatLibro.Ubicacion = txtUbicacion.Text;
                DatLibro.Cantidad = Convert.ToInt32(txtCantidad.Text);

                CantidadPrestada = CantidadLibro();
                CantidadNueva = Convert.ToInt32(txtCantidad.Text);

                if (CantidadNueva < CantidadPrestada)
                {
                    Interaction.MsgBox("Cambie la cantidad de libros." + Constants.vbCrLf + "El total de libros prestados excede a este", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
                    return;
                }
                else
                {
                    NuevoSotck = CantidadNueva - CantidadPrestada;
                    CambiarValorStock(NuevoSotck, CodLibro);
                }


                if (DLibros.ModificarLibro(DatLibro))
                    this.Close();
                else
                    Interaction.MsgBox("El Registro no fue Modificado", MsgBoxStyle.Exclamation, "Mensaje del Sistema");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private int CantidadLibro()
        {
            try
            {
                DataTable resultado;
                DatLibro.Codlibro = CodLibro;
                resultado = FuncLibro.VerificarCantidadLibro(DatLibro);

                int cantidad;

                if (resultado.Rows.Count > 0)
                {
                    cantidad = resultado.Rows.Count;
                    return cantidad;
                }
                else
                {
                    cantidad = 0;
                    return cantidad;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                return 0;
            }
        }
        private void CambiarValorStock(int nuevoSotck, int codLibro)
        {
            try
            {
                dconexion.AbrirConexion();
                string sql;
                sql = "UPDATE stocklibros SET Disponibles = '" + nuevoSotck.ToString() + "' WHERE CodLibro = '" + CodLibro.ToString() + "'";

                SqlCommand cmd = new SqlCommand(sql, dconexion.Conexion);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    //return true;
                }
                else
                    Interaction.MsgBox("NO se pudo modificar los datos debido a la Cantidad puesta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dconexion.CerrarConexion();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
