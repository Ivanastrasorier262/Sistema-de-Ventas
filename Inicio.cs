using CapaEntidades;
using FontAwesome.Sharp;
using CapaNegocios;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    // Cambiamos la herencia de Form a MaterialForm
    public partial class Inicio : MaterialForm
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;

            InitializeComponent();

            // === CONFIGURACIÓN DE MATERIALSKIN ===
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            this.DrawerTabControl = materialTabControl1;

            this.DrawerShowIconsWhenHidden = true;

            materialTabControl1.Visible = false;

            // Configura los colores (puedes ajustarlos a tu gusto)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE
            );

            // Esto habilita el menú lateral (Drawer)
            this.DrawerShowIconsWhenHidden = true;

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // Lógica de Permisos (Se mantiene igual)
            List<Permiso> ListarPermisos = new CN_PERMISO().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in menuStrip2.Items)
            {
                bool encontrado = ListarPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
                else
                {
                    foreach (ToolStripItem submenu in iconmenu.DropDownItems)
                    {
                        bool encontradoSubmenu = ListarPermisos.Any(m => m.NombreMenu == submenu.Name);
                        if (encontradoSubmenu == false)
                        {
                            submenu.Visible = false;
                        }
                    }
                }
            }

            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        // Método para abrir formularios dentro del panel (Se mantiene igual)
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Quitamos el color fijo para que se adapte al tema de Material
            // formulario.BackColor = Color.SteelBlue; 

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        // === EVENTOS DE CLIC (Mantenemos tus rutas originales) ===

        private void menuusuario_Click(object sender, EventArgs e) => AbrirFormulario((IconMenuItem)sender, new frmUsuarios());

        private void submenucategoria_Click(object sender, EventArgs e) => AbrirFormulario(menumantenedor, new frmCategoria());

        private void submenuproducto_Click(object sender, EventArgs e) => AbrirFormulario(menumantenedor, new frmProducto());

        private void submenuregistrarventa_Click(object sender, EventArgs e) => AbrirFormulario(manuventas, new frmVentas());

        private void verdetalleventa_Click(object sender, EventArgs e) => AbrirFormulario(manuventas, new frmDetalleVenta());

        private void submenuregistrarcompra_Click(object sender, EventArgs e) => AbrirFormulario(manucompras, new frmCompras());

        private void submenuverdetallecompra_Click(object sender, EventArgs e) => AbrirFormulario(manucompras, new frmDetalleCompra());

        private void menuclientes_Click(object sender, EventArgs e) => AbrirFormulario((IconMenuItem)sender, new frmClientes());

        private void menuproveedor_Click(object sender, EventArgs e) => AbrirFormulario((IconMenuItem)sender, new frmProveedores());

        private void menureportes_Click(object sender, EventArgs e) => AbrirFormulario((IconMenuItem)sender, new frmreportes());

        // Eventos vacíos para evitar errores si están en el Designer
        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void iconMenuItem4_Click(object sender, EventArgs e) { }
        private void contenedor_Paint(object sender, PaintEventArgs e) { }
        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Detectamos qué pestaña se seleccionó en el menú lateral
            string opcion = materialTabControl1.SelectedTab.Text;

            // Ejecutamos la lógica según el nombre de la pestaña
            switch (opcion)
            {
                case "Usuarios":
                    AbrirFormulario(menuusuario, new frmUsuarios());
                    break;
                case "Mantenedor":
                    // Aquí puedes decidir cuál abrir por defecto o dejarlo vacío
                    break;
                case "Ventas":
                    AbrirFormulario(manuventas, new frmVentas());
                    break;
                case "Clientes":
                    AbrirFormulario(menuclientes, new frmClientes());
                    break;
                case "Proveedores":
                    AbrirFormulario(menuproveedor, new frmProveedores());
                    break;
                case "Reportes":
                    AbrirFormulario(menureportes, new frmreportes());
                    break;
            }
        }
    }
}