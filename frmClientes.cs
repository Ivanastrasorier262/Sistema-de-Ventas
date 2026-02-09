using CapaDeDatos;
using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
// Esto soluciona el error CS0104 de ambigüedad de colores
using Color = System.Drawing.Color;

namespace CapaPresentacion
{
    public partial class frmClientes : MaterialForm
    {
        public frmClientes()
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

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // ===== ESTADO =====
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            // ===== BUSQUEDA =====
            cbobusqueda.Items.Clear();
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                // El nombre de tu columna botón es "btnselaccionar" (con una 'c' extra según tu diseñador)
                if (columna.Visible == true && columna.Name != "btnselaccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo()
                    {
                        Valor = columna.Name,
                        Texto = columna.HeaderText
                    });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            // ===== CARGAR LISTA =====
            List<Cliente> lista = new CN_Cliente().Listar();
            foreach (Cliente item in lista)
            {
                dgvData.Rows.Add(new object[] {
                    "",
                    item.idCliente,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Cliente objcliente = new Cliente()
            {
                idCliente = Convert.ToInt32(txtId.Text),
                Documento = Convert.ToInt32(txtDocumento.Text),
                NombreCompleto = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1
            };

            if (objcliente.idCliente == 0)
            {
                int idgenerado = new CN_Cliente().Registrar(objcliente, out mensaje);

                if (idgenerado != 0)
                {
                    dgvData.Rows.Add(new object[] { "", idgenerado, txtDocumento.Text, txtNombre.Text, txtCorreo.Text, txtTelefono.Text,
                        ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString()
                    });
                    Limpiar();
                }
                else { MessageBox.Show(mensaje); }
            }
            else
            {
                bool resultado = new CN_Cliente().Editar(objcliente, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txtId.Text; // CAMBIADO: "id" en lugar de "IdCliente"
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtNombre.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor;
                    row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto;
                    Limpiar();
                }
                else { MessageBox.Show(mensaje); }
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // CAMBIO CLAVE: El nombre en tu diseñador es "btnselaccionar"
            if (dgvData.Columns[e.ColumnIndex].Name == "btnselaccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    // CAMBIO CLAVE: La columna se llama "id" según tu InitializeComponent
                    txtId.Text = dgvData.Rows[indice].Cells["id"].Value.ToString();
                    txtDocumento.Text = dgvData.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dgvData.Rows[indice].Cells["Telefono"].Value.ToString();

                    string estado = dgvData.Rows[indice].Cells["EstadoValor"].Value.ToString();
                    foreach (OpcionCombo oc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(estado))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente obj = new Cliente() { idCliente = Convert.ToInt32(txtId.Text) };
                    bool respuesta = new CN_Cliente().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else { MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
            }
            else { MessageBox.Show("Seleccione un cliente válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
            foreach (DataGridViewRow row in dgvData.Rows) { row.Visible = true; }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cboEstado.SelectedIndex = 0;
            txtDocumento.Select();
        }
    }
}