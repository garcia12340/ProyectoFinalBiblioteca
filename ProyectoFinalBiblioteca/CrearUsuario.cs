using CapaDatos;
using CapaModelo;
using Microsoft.VisualBasic;
using ProyectoFinalBiblioteca.Enums;
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
    public partial class CrearUsuario : Form
    {
        DUsuario FuncUsuario = new DUsuario();
        public static object oObjecto;
        DataTable tabla = new DataTable();
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            //txtidreferencia.Text = "0";
            txtidusuario.Text = "0";

            cboestado.Items.Add(new ComboBoxItem() { Value = true, Text = "Activo" });
            cboestado.Items.Add(new ComboBoxItem() { Value = false, Text = "No Activo" });
            cboestado.DisplayMember = "Text";
            cboestado.ValueMember = "Value";
            cboestado.SelectedIndex = 0;

            List<LRol> oListaRol = DRol.Listar();

            cborol.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Rol" });
            foreach (LRol row in oListaRol.Where(x => x.Activo == true))
            {
                cborol.Items.Add(new ComboBoxItem() { Value = row.IdRol, Text = row.Descripcion });
            }
            cborol.DisplayMember = "Text";
            cborol.ValueMember = "Value";
            cborol.SelectedIndex = 0;
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<LUsuario> oListaUsuario = DUsuario.ObtenerUsuarios();
            if (oListaUsuario == null)
                return;

            if (oListaUsuario.Count > 0)
            {
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();
                cboFiltro.Items.Clear();

                lblTotalRegistros.Text = oListaUsuario.Count.ToString();

                tabla.Columns.Add("IdUsuario", typeof(int));
                tabla.Columns.Add("Nombres", typeof(string));
                tabla.Columns.Add("Apellidos", typeof(string));
                tabla.Columns.Add("Usuario", typeof(string));
                tabla.Columns.Add("Contraseña", typeof(string));
                tabla.Columns.Add("IdRol", typeof(int));
                tabla.Columns.Add("Rol", typeof(string));
               // tabla.Columns.Add("DescripcionReferencia", typeof(string));
                tabla.Columns.Add("Estado", typeof(string));
                tabla.Columns.Add("Activo", typeof(bool));

                foreach (LUsuario row in oListaUsuario)
                {
                    tabla.Rows.Add(row.IdUsuario, row.Nombres, row.Apellidos, row.LoginUsuario, row.Clave, row.IdRol, row.oRol.Descripcion,
                        row.Activo == true ? "Activo" : "No Activo", row.Activo);
                }

                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdUsuario"].Visible = false;
                dgvdata.Columns["IdRol"].Visible = false;
                dgvdata.Columns["Activo"].Visible = false;

                foreach (DataGridViewColumn cl in dgvdata.Columns)
                {
                    if (cl.Visible == true)
                    {
                        cboFiltro.Items.Add(cl.HeaderText);
                    }
                }
                cboFiltro.SelectedIndex = 0;
            }
        }
 
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            gbdatos.Enabled = true;

            BtnNuevo.Visible = false;
            BtnGuardar.Visible = true;

            BtnEditar.Visible = false;
            BtnCancelar.Visible = true;

            BtnEliminar.Visible = false;
            cboestado.Enabled = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool eseditar = Convert.ToInt32(txtidusuario.Text) != 0 ? true : false;

            LUsuario oUsuario = new LUsuario()
            {
                IdUsuario = Convert.ToInt32(txtidusuario.Text),
                Nombres = txtnombres.Text,
                Apellidos = txtapellidos.Text,
                IdRol = int.Parse(((ComboBoxItem)cborol.SelectedItem).Value.ToString()),
                LoginUsuario = txtusuario.Text,
                Clave = txtcontrasenia.Text,
                Activo = Convert.ToBoolean(((ComboBoxItem)cboestado.SelectedItem).Value)
            };

            bool respuesta = false;

            string msgOk = "";
            string msgError = "";

            if (eseditar)
            {
                respuesta = DUsuario.ModificarUsuario(oUsuario);
                msgOk = "Se guardaron los cambios";
                msgError = "No se pudo guardar los cambios";

            }
            else
            {
                respuesta = DUsuario.RegistrarUsuario(oUsuario);
                msgOk = "Registro exitoso";
                msgError = "No se pudo registrar";
            }

            if (respuesta)
            {
                MessageBox.Show(msgOk, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reestablecer();
                CargarDatos();
            }
            else
            {
                MessageBox.Show(msgError, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Reestablecer()
        {
            gbdatos.Enabled = false;

            BtnNuevo.Visible = true;
            BtnGuardar.Visible = false;

            BtnEditar.Visible = true;
            BtnCancelar.Visible = false;

            BtnEliminar.Visible = true;

            //txtidusuario.Text = "0";
            //txtidreferencia.Text = "0";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtusuario.Text = "";
            txtcontrasenia.Text = "";
            //cboreferencia.SelectedIndex = 0;
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvdata.SelectedRows[0];
                int index = currentRow.Index;


                txtidusuario.Text = dgvdata.Rows[index].Cells["IdUsuario"].Value.ToString();
                txtnombres.Text = dgvdata.Rows[index].Cells["Nombres"].Value.ToString();
                txtapellidos.Text = dgvdata.Rows[index].Cells["Apellidos"].Value.ToString();
                txtusuario.Text = dgvdata.Rows[index].Cells["Usuario"].Value.ToString();
                txtcontrasenia.Text = dgvdata.Rows[index].Cells["Contraseña"].Value.ToString();


                //foreach (ComboBoxItem item in cboreferencia.Items)
                //{
                //    if ((string)item.Value == dgvdata.Rows[index].Cells["DescripcionReferencia"].Value.ToString())
                //    {
                //        int id = cboreferencia.Items.IndexOf(item);
                //        cboreferencia.SelectedIndex = id;
                //        break;
                //    }
                //}

                foreach (ComboBoxItem item in cborol.Items)
                {
                    if ((int)item.Value == (int)dgvdata.Rows[index].Cells["IdRol"].Value)
                    {
                        int id = cborol.Items.IndexOf(item);
                        cborol.SelectedIndex = id;
                        break;
                    }
                }

                foreach (ComboBoxItem item in cboestado.Items)
                {
                    if ((bool)item.Value == (bool)dgvdata.Rows[index].Cells["Activo"].Value)
                    {
                        int id = cboestado.Items.IndexOf(item);
                        cboestado.SelectedIndex = id;
                        break;
                    }
                }


            }
            else
            {
                MessageBox.Show("Selecciona un registro de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            gbdatos.Enabled = true;

            BtnNuevo.Visible = false;
            BtnGuardar.Visible = true;

            BtnEditar.Visible = false;
            BtnCancelar.Visible = true;

            BtnEliminar.Visible = false;
            cboestado.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            gbdatos.Enabled = false;

            BtnNuevo.Visible = true;
            BtnGuardar.Visible = false;

            BtnEditar.Visible = true;
            BtnCancelar.Visible = false;

            BtnEliminar.Visible = true;
            Reestablecer();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvdata.SelectedRows[0];
                int index = currentRow.Index;
                if (MessageBox.Show("¿Desea eliminar el usuario " + dgvdata.Rows[index].Cells["Usuario"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idusuario = Convert.ToInt32(dgvdata.Rows[index].Cells["IdUsuario"].Value.ToString());

                    bool respuesta = DUsuario.EliminarUsuario(idusuario);
                    if (respuesta)
                    {
                        MessageBox.Show("Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecciona un registro de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
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
