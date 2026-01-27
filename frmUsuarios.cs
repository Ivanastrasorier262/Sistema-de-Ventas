using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;



namespace CapaPresentacion;


public partial class frmUsuarios : MaterialForm

{
    public frmUsuarios()
    {
        InitializeComponent();


        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = false;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

        materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue700,
            Primary.Blue800,
            Primary.Blue300,
            Accent.LightBlue200,
            TextShade.BLACK
        );
        EstilizarBotones();
    }
    private void EstilizarBotones()
    {
        EstiloBoton(btnguardar, Color.SeaGreen);
        EstiloBoton(btnlimpiar, Color.SteelBlue);
        EstiloBoton(btneliminar, Color.IndianRed);
    }

    private void EstiloBoton(FontAwesome.Sharp.IconButton btn, Color color)
    {
        btn.BackColor = color;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.ForeColor = Color.White;
        btn.IconColor = Color.White;
        btn.Cursor = Cursors.Hand;
    }



    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void frmUsuarios_Load(object sender, EventArgs e)
    {
        // ===== ESTADO =====
        cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
        cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
        cboEstado.DisplayMember = "Texto";
        cboEstado.ValueMember = "Valor";
        cboEstado.SelectedIndex = 0;

        // ===== ROLES =====
        cboRol.Items.Clear();
        foreach (Rol item in new CN_Rol().Listar())
        {
            cboRol.Items.Add(new OpcionCombo()
            {
                Valor = item.idRol,
                Texto = item.Descripcion
            });
        }
        cboRol.DisplayMember = "Texto";
        cboRol.ValueMember = "Valor";
        cboRol.SelectedIndex = 0;

        // ===== BUSQUEDA =====
        cbobusqueda.Items.Clear();
        foreach (DataGridViewColumn col in dgvData.Columns)
        {
            if (col.Visible && col.Name != "btnSeleccionar")
            {
                cbobusqueda.Items.Add(new OpcionCombo()
                {
                    Valor = col.Name,
                    Texto = col.HeaderText
                });
            }
        }
        cbobusqueda.DisplayMember = "Texto";
        cbobusqueda.ValueMember = "Valor";
        cbobusqueda.SelectedIndex = 0;

        // ===== LISTADO =====
        dgvData.Rows.Clear();
        foreach (Usuario item in new CN_Usuario().Listar())
        {
            dgvData.Rows.Add(new object[]
            {
            "",
            item.IdUsuario,
            item.Documento,
            item.NombreCompleto,
            item.Correo,
            item.Clave,
            item.oRol.idRol,
            item.oRol.Descripcion,
            item.Estado ? 1 : 0,
            item.Estado ? "Activo" : "No Activo"
            });
        }
    }


    private void btnguardar_Click(object sender, EventArgs e)
    {
        string mensaje = string.Empty;

        Usuario objusuario = new Usuario()
        {
            IdUsuario = Convert.ToInt32(txtId.Text),
            Documento = txtDocumento.Text,
            NombreCompleto = txtNombre.Text,
            Correo = txtCorreo.Text,
            Clave = txtClave.Text,
            oRol = new Rol()
            {
                idRol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor)
            },
            Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1
        };

        // SI ES NUEVO
        if (objusuario.IdUsuario == 0)
        {
            int idusuario = new CN_Usuario().Registrar(objusuario, out mensaje);

            if (idusuario != 0)
            {
                dgvData.Rows.Add(new object[]
                {
            "",
            idusuario,
            txtDocumento.Text,
            txtNombre.Text,
            txtCorreo.Text,
            txtClave.Text,
            ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
            ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
            ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
            ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString()
                });

                MessageBox.Show("Usuario registrado correctamente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }
            else
            {
                MessageBox.Show(mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // SI ES EDICIÓN
        else
        {
            bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                row.Cells["id"].Value = txtId.Text;
                row.Cells["Documento"].Value = txtDocumento.Text;
                row.Cells["NombreCompleto"].Value = txtNombre.Text;
                row.Cells["Correo"].Value = txtCorreo.Text;
                row.Cells["Clave"].Value = txtClave.Text;
                row.Cells["IdRol"].Value = ((OpcionCombo)cboRol.SelectedItem).Valor;
                row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto;
                row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor;
                row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto;



                Limpiar();


            }
            else
            {
                MessageBox.Show(mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



    private void Limpiar()
    {
        txtIndice.Text = "-1";
        txtId.Text = "0";
        txtDocumento.Text = "";
        txtNombre.Text = "";
        txtCorreo.Text = "";
        txtClave.Text = "";
        txtConfirmarClave.Text = "";
        cboRol.SelectedIndex = 0;
        cboEstado.SelectedIndex = 0;
        txtDocumento.Select();
    }

    private void label12_Click(object sender, EventArgs e)
    {

    }

    private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgvData.Columns[e.ColumnIndex].Name == "btnselaccionar"
            && e.RowIndex >= 0)
        {
            txtIndice.Text = e.RowIndex.ToString();
            txtId.Text = dgvData.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtDocumento.Text = dgvData.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
            txtNombre.Text = dgvData.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();
            txtCorreo.Text = dgvData.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            txtClave.Text = dgvData.Rows[e.RowIndex].Cells["Clave"].Value.ToString();
            txtConfirmarClave.Text = txtClave.Text;

            int idRol = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["idRol"].Value);
            foreach (OpcionCombo item in cboRol.Items)
            {
                if (Convert.ToInt32(item.Valor) == idRol)
                {
                    cboRol.SelectedItem = item;
                    break;
                }
            }

            int estado = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["EstadoValor"].Value);
            foreach (OpcionCombo item in cboEstado.Items)
            {
                if (Convert.ToInt32(item.Valor) == estado)
                {
                    cboEstado.SelectedItem = item;
                    break;
                }
            }
        }
    }



    private void textBox4_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void btneliminar_Click(object sender, EventArgs e)
    {
        if (txtIndice.Text == "-1")
        {
            MessageBox.Show("Seleccione un usuario",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show("¿Desea eliminar el usuario?",
            "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
        {
            string mensaje;

            Usuario obj = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text)
            };

            bool respuesta = new CN_Usuario().Eliminar(obj, out mensaje);

            if (respuesta)
            {
                dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                Limpiar();
            }
            else
            {
                MessageBox.Show(mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



    private void btnbuscar_Click(object sender, EventArgs e)
    {
        string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

        if (dgvData.Rows.Count > 0)
        {
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textbusqueda.Text.Trim().ToUpper()))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }
    }

    private void btnlimpiarbuscador_Click(object sender, EventArgs e)
    {
        textbusqueda.Text = "";
        foreach (DataGridViewRow row in dgvData.Rows)
        {
            row.Visible = true;
        }
    }
}


