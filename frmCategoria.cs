using CapaDeDatos;
using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCategoria : MaterialForm
    {
        public frmCategoria()
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
            EstiloBoton(btnGuardar, Color.SeaGreen);
            EstiloBoton(btnLimpiar, Color.SteelBlue);
            EstiloBoton(btnEliminar, Color.IndianRed);
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

        private void frmCategoria_Load(object sender, EventArgs e)
        {


            // ================= ESTADO =================
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            // ================= BUSQUEDA =================
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "btnSeleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo()
                    {
                        Valor = columna.Name,
                        Texto = columna.HeaderText
                    });
                }
            }

            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            // ================= LISTADO =================
            CargarListado();
        }

        // ================= LISTAR =================
        private void CargarListado()
        {
            dgvData.Rows.Clear();

            List<Categoria> lista = new CN_Categoria().Listar();

            foreach (Categoria item in lista)
            {
                dgvData.Rows.Add(new object[]
                {
                    "",
                    item.IdCategoria,
                    item.Descripcion,
                    item.Estado ? 1 : 0,
                    item.Estado ? "Activo" : "No Activo"
                });
            }
        }

        // ================= GUARDAR =================
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje;

            Categoria obj = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtId.Text),
                Descripcion = txtDescripcion.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1
            };

            // ================= NUEVO =================
            if (obj.IdCategoria == 0)
            {
                int idGenerado = new CN_Categoria().Registrar(obj, out mensaje);

                if (idGenerado != 0)
                {
                    MessageBox.Show("Categoría registrada correctamente", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarListado();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // ================= EDICIÓN =================
            else
            {
                if (txtIndice.Text == "-1")
                {
                    MessageBox.Show("Seleccione una categoría para editar", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool resultado = new CN_Categoria().Editar(obj, out mensaje);

                if (resultado)
                {
                    MessageBox.Show("Categoría actualizada correctamente", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarListado();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= LIMPIAR =================
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDescripcion.Text = "";
            cboEstado.SelectedIndex = 0;
        }

        // ================= SELECCIONAR =================
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar" && e.RowIndex >= 0)
            {
                txtIndice.Text = e.RowIndex.ToString();

                txtId.Text = dgvData.Rows[e.RowIndex]
                    .Cells["colId"].Value.ToString();

                txtDescripcion.Text = dgvData.Rows[e.RowIndex]
                    .Cells["colDescripcion"].Value.ToString();

                int estado = Convert.ToInt32(
                    dgvData.Rows[e.RowIndex].Cells["colEstadoValor"].Value
                );

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

        // ================= LIMPIAR BOTÓN =================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // ================= ELIMINAR =================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIndice.Text == "-1")
            {
                MessageBox.Show("Seleccione una categoría para eliminar",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar la categoría?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                string mensaje;

                Categoria obj = new Categoria()
                {
                    IdCategoria = Convert.ToInt32(txtId.Text)
                };

                bool respuesta = new CN_Categoria().Eliminar(obj, out mensaje);

                if (respuesta)
                {
                    MessageBox.Show("Categoría eliminada correctamente", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarListado();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }
    }
}


