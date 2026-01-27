namespace CapaPresentacion;
using CapaEntidades;
using FontAwesome.Sharp;
using CapaNegocios;

public partial class Inicio : Form
{

    private static Usuario usuarioActual;
    private static IconMenuItem MenuActivo;
    private static Form FormularioActivo = null;
    public Inicio(Usuario objusuario = null)
    {
        if(objusuario == null) usuarioActual = new Usuario() { NombreCompleto ="ADMIN PREDEFINIDO", IdUsuario = 1};
        else 
            usuarioActual = objusuario;

           
        InitializeComponent();
    }

    private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Inicio_Load(object sender, EventArgs e)
    {
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
    

    private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void iconMenuItem4_Click(object sender, EventArgs e)
    {

    }

    private void contenedor_Paint(object sender, PaintEventArgs e)
    {

    }

    private void menuproveedor_Click(object sender, EventArgs e)
    {
        AbrirFormulario((IconMenuItem)sender, new frmProveedores());
    }

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
        formulario.BackColor = Color.SteelBlue;

        contenedor.Controls.Add(formulario);
        formulario.Show();


    }



    private void menuusuario_Click(object sender, EventArgs e)
    {
        AbrirFormulario((IconMenuItem)sender, new frmUsuarios());

    }

    private void submenucategoria_Click(object sender, EventArgs e)
    {
        AbrirFormulario(menumantenedor, new frmCategoria());
    }

    private void submenuproducto_Click(object sender, EventArgs e)
    {
        AbrirFormulario(menumantenedor, new frmProducto());
    }

    private void submenuregistrarventa_Click(object sender, EventArgs e)
    {
        AbrirFormulario(manuventas, new frmVentas());
    }

    private void verdetalleventa_Click(object sender, EventArgs e)
    {
        AbrirFormulario(manuventas, new frmDetalleVenta());
    }

    private void submenuregistrarcompra_Click(object sender, EventArgs e)
    {
        AbrirFormulario(manucompras, new frmCompras());

    }

    private void submenuverdetallecompra_Click(object sender, EventArgs e)
    {
        AbrirFormulario(manucompras, new frmDetalleCompra());
    }

    private void menuclientes_Click(object sender, EventArgs e)
    {
        AbrirFormulario((IconMenuItem)sender, new frmClientes());
    }

    private void menureportes_Click(object sender, EventArgs e)
    {
        AbrirFormulario((IconMenuItem)sender, new frmreportes());
    }
}


