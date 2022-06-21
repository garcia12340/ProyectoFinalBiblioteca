using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBiblioteca
{
    public partial class MDIMaster : Form
    {
        public static int IdUsuario;
        public MDIMaster(int pIdUsuario = 0)
        {
            InitializeComponent();
            IdUsuario = pIdUsuario;
            //DEFINIMOS DISEÑO DEL FORMULARIO MDI
            this.IsMdiContainer = true;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void MDIMaster_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            if (IdUsuario == 0)
            {
                this.Close();
            }

            Configuracion.OUsuario = DUsuario.ObtenerDetalleUsuario(IdUsuario);

            StatusStrip w = new StatusStrip();
            w.Dock = DockStyle.Top;
            w.Font = new System.Drawing.Font("Segoe UI", 12F);

            ToolStripStatusLabel lblUsuario = new ToolStripStatusLabel("Usuario: ");
            ToolStripStatusLabel lblData1 = new ToolStripStatusLabel(Configuracion.OUsuario.Nombres + " " + Configuracion.OUsuario.Apellidos);
            lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUsuario.Spring = true;
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;

            ToolStripStatusLabel lblTipoUsuario = new ToolStripStatusLabel("Rol: ");
            ToolStripStatusLabel lblData2 = new ToolStripStatusLabel(Configuracion.OUsuario.oRol.Descripcion);
            lblTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            w.Items.Add(lblUsuario);
            w.Items.Add(lblData1);
            w.Items.Add(lblTipoUsuario);
            w.Items.Add(lblData2);
            Controls.Add(w);

            MenuStrip menu = new MenuStrip();
            menu.BackColor = Color.LightSkyBlue;

            foreach (CapaModelo.LMenu oMenu in Configuracion.OUsuario.oListaMenu)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(oMenu.Nombre);
                menuItem.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
                menuItem.TextImageRelation = TextImageRelation.ImageAboveText;

                string pathImage1 = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @oMenu.Icono);
                menuItem.Image = new Bitmap(pathImage1);
                menuItem.ImageScaling = ToolStripItemImageScaling.None;

                if (oMenu.oSubMenu != null)
                {
                    foreach (LSubMenu oSubMenu in oMenu.oSubMenu.Where(x => x.Activo == true))
                    {
                        ToolStripMenuItem SubMenuStringItem = new ToolStripMenuItem(oSubMenu.Nombre, null, ToolStripMenuItem_Click, oSubMenu.NombreFormulario);
                        SubMenuStringItem.Font = new System.Drawing.Font("Segoe UI", 12F);
                        string pathImage2 = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @"\Iconos\icon_item.png");
                        SubMenuStringItem.Image = new Bitmap(pathImage2);
                        menuItem.DropDownItems.Add(SubMenuStringItem);
                    }
                }
                menu.Items.Add(menuItem);
            }

            ToolStripMenuItem MnuStripItemExit = new ToolStripMenuItem("Salir", null, ToolStripMenuItemSalir_Click, "");
            MnuStripItemExit.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            MnuStripItemExit.TextImageRelation = TextImageRelation.ImageAboveText;
            string pathImage3 = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @"\Iconos\Salir.png");
            MnuStripItemExit.Image = new Bitmap(pathImage3);
            MnuStripItemExit.ImageScaling = ToolStripItemImageScaling.None;
            menu.Items.Add(MnuStripItemExit);


            this.MainMenuStrip = menu;
            Controls.Add(menu);
        }

        private void ToolStripMenuItemSalir_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem oMenuSelect = (ToolStripMenuItem)sender;

            if (oMenuSelect.Name != "")
            {
                Assembly asm = Assembly.GetEntryAssembly();

                Type formtype = asm.GetType(string.Format("{0}.{1}", asm.GetName().Name, oMenuSelect.Name));

                if (formtype == null)
                {
                    MessageBox.Show("Formulario no encontrado");
                }
                else
                {
                    Form formulario = (Form)Activator.CreateInstance(formtype);
                    MostrarFormulario(formulario, this);

                    formulario.WindowState = FormWindowState.Normal;
                    formulario.StartPosition = FormStartPosition.CenterScreen;
                    formulario.Activate();
                }
            }
        }

        public void MostrarFormulario(Form frmhijo, Form frmpapa)
        {
            Form FormularioEncontrado = new Form();
            bool cargado = false;
            foreach (Form Formulario in frmpapa.MdiChildren)
            {
                if (Formulario.Name == frmhijo.Name)
                {
                    FormularioEncontrado = Formulario;
                    cargado = true;
                    break;
                }
            }

            if (!cargado)
            {
                frmhijo.MdiParent = frmpapa;
                frmhijo.Show();
            }
            else
            {
                FormularioEncontrado.WindowState = FormWindowState.Normal;
                FormularioEncontrado.Activate();
            }

        }
    }
}
