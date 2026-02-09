using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProducto : MaterialForm
    {
        public frmProducto()
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            // ===== ESTADO =====
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            // ===== CATEGORIAS =====
            cboCategoria.Items.Clear();
            foreach (Categoria item in new CN_Categoria().Listar())
            {
                cboCategoria.Items.Add(new OpcionCombo()
                {
                    Valor = item.IdCategoria,
                    Texto = item.Descripcion
                });
            }
            cboCategoria.DisplayMember = "Texto";
            cboCategoria.ValueMember = "Valor";
            cboCategoria.SelectedIndex = 0;

            // ===== BUSQUEDA =====
            cbobusqueda.Items.Clear();
            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (col.Visible && col.Name != "btnselaccionar")
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
            foreach (Producto item in new CN_Producto().Listar())
            {
                dgvData.Rows.Add(new object[]
                {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado ? 1 : 0,
                    item.Estado ? "Activo" : "No Activo"
                });
            }
        }

        // ================= GUARDAR =================


        // ================= SELECCIONAR =================
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnselaccionar"
        && e.RowIndex >= 0)
            {
                txtIndice.Text = e.RowIndex.ToString();
                txtId.Text = dgvData.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtCodigo.Text = dgvData.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtNombre.Text = dgvData.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvData.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();

                int idCategoria = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["idCategoria"].Value);
                foreach (OpcionCombo item in cboCategoria.Items)
                {
                    if (Convert.ToInt32(item.Valor) == idCategoria)
                    {
                        cboCategoria.SelectedItem = item;
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





        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cboCategoria.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            txtCodigo.Select();
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
         string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe completar Código y Nombre",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(txtId.Text),
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                oCategoria = new Categoria()
                {
                    IdCategoria = Convert.ToInt32(((OpcionCombo)cboCategoria.SelectedItem).Valor)
                },
                Stock = 0,
                PrecioCompra = 0,
                PrecioVenta = 0,
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1
            };

            string mensaje;

            if (obj.IdProducto == 0)
            {
                int idGenerado = new CN_Producto().Registrar(obj, out mensaje);

                if (idGenerado != 0)
                {
                    dgvData.Rows.Add(new object[]
                    {
                "",
                idGenerado,
                obj.Codigo,
                obj.Nombre,
                obj.Descripcion,
                obj.oCategoria.IdCategoria,
                cboCategoria.Text,
                obj.Stock,
                obj.PrecioCompra,
                obj.PrecioVenta,
                obj.Estado ? 1 : 0,
                obj.Estado ? "Activo" : "No Activo"
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool resultado = new CN_Producto().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];

                    row.Cells["Codigo"].Value = obj.Codigo;
                    row.Cells["Nombre"].Value = obj.Nombre;
                    row.Cells["Descripcion"].Value = obj.Descripcion;
                    row.Cells["idCategoria"].Value = obj.oCategoria.IdCategoria;
                    row.Cells["Categoria"].Value = cboCategoria.Text;
                    row.Cells["EstadoValor"].Value = obj.Estado ? 1 : 0;
                    row.Cells["Estado"].Value = obj.Estado ? "Activo" : "No Activo";

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) == 0)
                return;

            if (MessageBox.Show("¿Desea eliminar el producto?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje;

                Producto obj = new Producto()
                {
                    IdProducto = Convert.ToInt32(txtId.Text)
                };

                bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

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


        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[columnaFiltro].Value.ToString()
                    .Trim().ToUpper().Contains(textbusqueda.Text.Trim().ToUpper()))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }

        private void btnlimpiarbuscador_Click_1(object sender, EventArgs e)
        {
            textbusqueda.Text = "";

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show(
                    "No hay datos para exportar",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            // 1️⃣ Crear DataTable UNA SOLA VEZ
            DataTable dt = new DataTable();

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Categoria");
            dt.Columns.Add("Stock");
            dt.Columns.Add("PrecioCompra");
            dt.Columns.Add("PrecioVenta");
            dt.Columns.Add("Estado");

            // 2️⃣ Agregar filas
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.IsNewRow) continue;

                dt.Rows.Add(
                    row.Cells[2].Value?.ToString(),
                    row.Cells[3].Value?.ToString(),
                    row.Cells[4].Value?.ToString(),
                    row.Cells[6].Value?.ToString(),
                    row.Cells[7].Value?.ToString(),
                    row.Cells[8].Value?.ToString(),
                    row.Cells[9].Value?.ToString(),
                    row.Cells[11].Value?.ToString()
                );
            }

            // 3️⃣ Guardar archivo
            SaveFileDialog saveFile = new SaveFileDialog
            {
                FileName = $"ReporteProductos_{DateTime.Now:ddMMyyyyHHmmss}.xlsx",
                Filter = "Excel Files | *.xlsx"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XLWorkbook wb = new XLWorkbook();
                    var hoja = wb.Worksheets.Add(dt, "Informe");
                    hoja.ColumnsUsed().AdjustToContents();
                    wb.SaveAs(saveFile.FileName);

                    MessageBox.Show(
                        "Reporte generado correctamente",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "No se pudo generar el reporte\n" + ex.Message,
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );
                }
            }
        }
    }
}




