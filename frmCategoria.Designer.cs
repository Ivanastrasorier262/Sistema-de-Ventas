using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    partial class frmCategoria
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTituloDetalle = new MaterialLabel();
            labelDescripcion = new MaterialLabel();
            labelEstado = new MaterialLabel();
            labelTituloLista = new MaterialLabel();
            labelBuscarPor = new MaterialLabel();
            txtDescripcion = new TextBox();
            cboEstado = new ComboBox();
            txtBusqueda = new TextBox();
            cboBusqueda = new ComboBox();
            txtIndice = new TextBox();
            txtId = new TextBox();
            btnGuardar = new IconButton();
            btnLimpiar = new IconButton();
            btnEliminar = new IconButton();
            btnBuscar = new IconButton();
            btnLimpiarBuscador = new IconButton();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            colId = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colEstadoValor = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // labelTituloDetalle
            // 
            labelTituloDetalle.BackColor = Color.Transparent;
            labelTituloDetalle.Depth = 0;
            labelTituloDetalle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTituloDetalle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelTituloDetalle.ForeColor = Color.Black;
            labelTituloDetalle.Location = new Point(40, 80);
            labelTituloDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            labelTituloDetalle.Name = "labelTituloDetalle";
            labelTituloDetalle.Size = new Size(237, 35);
            labelTituloDetalle.TabIndex = 0;
            labelTituloDetalle.Text = "Detalle de Categoría";
            // 
            // labelDescripcion
            // 
            labelDescripcion.Depth = 0;
            labelDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDescripcion.Location = new Point(40, 170);
            labelDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(100, 23);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "Descripción";
            // 
            // labelEstado
            // 
            labelEstado.Depth = 0;
            labelEstado.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelEstado.Location = new Point(40, 240);
            labelEstado.MouseState = MaterialSkin.MouseState.HOVER;
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(100, 23);
            labelEstado.TabIndex = 3;
            labelEstado.Text = "Estado";
            // 
            // labelTituloLista
            // 
            labelTituloLista.Depth = 0;
            labelTituloLista.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTituloLista.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelTituloLista.Location = new Point(350, 80);
            labelTituloLista.MouseState = MaterialSkin.MouseState.HOVER;
            labelTituloLista.Name = "labelTituloLista";
            labelTituloLista.Size = new Size(300, 30);
            labelTituloLista.TabIndex = 8;
            labelTituloLista.Text = "Lista de Categorías";
            // 
            // labelBuscarPor
            // 
            labelBuscarPor.Depth = 0;
            labelBuscarPor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelBuscarPor.Location = new Point(490, 121);
            labelBuscarPor.MouseState = MaterialSkin.MouseState.HOVER;
            labelBuscarPor.Name = "labelBuscarPor";
            labelBuscarPor.Size = new Size(100, 23);
            labelBuscarPor.TabIndex = 9;
            labelBuscarPor.Text = "Buscar por";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(40, 195);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(230, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Location = new Point(40, 265);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(230, 28);
            cboEstado.TabIndex = 4;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(801, 117);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(150, 27);
            txtBusqueda.TabIndex = 11;
            // 
            // cboBusqueda
            // 
            cboBusqueda.Location = new Point(635, 116);
            cboBusqueda.Name = "cboBusqueda";
            cboBusqueda.Size = new Size(120, 28);
            cboBusqueda.TabIndex = 10;
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(0, 0);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(100, 27);
            txtIndice.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(0, 0);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = IconFont.Auto;
            btnGuardar.IconSize = 16;
            btnGuardar.Location = new Point(40, 320);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(230, 35);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnguardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SteelBlue;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = IconChar.Broom;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = IconFont.Auto;
            btnLimpiar.IconSize = 16;
            btnLimpiar.Location = new Point(40, 365);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(230, 35);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.OrangeRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = IconChar.Trash;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = IconFont.Auto;
            btnEliminar.IconSize = 16;
            btnEliminar.Location = new Point(40, 410);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(230, 35);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = IconFont.Auto;
            btnBuscar.IconSize = 16;
            btnBuscar.Location = new Point(983, 114);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(60, 30);
            btnBuscar.TabIndex = 12;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.IconChar = IconChar.Broom;
            btnLimpiarBuscador.IconColor = Color.Black;
            btnLimpiarBuscador.IconFont = IconFont.Auto;
            btnLimpiarBuscador.IconSize = 16;
            btnLimpiarBuscador.Location = new Point(1049, 114);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(53, 30);
            btnLimpiarBuscador.TabIndex = 13;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.ColumnHeadersHeight = 29;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, colId, colDescripcion, colEstadoValor, colEstado });
            dgvData.Location = new Point(350, 170);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(800, 300);
            dgvData.TabIndex = 14;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.MinimumWidth = 6;
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 125;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            colDescripcion.Width = 250;
            // 
            // colEstadoValor
            // 
            colEstadoValor.MinimumWidth = 6;
            colEstadoValor.Name = "colEstadoValor";
            colEstadoValor.ReadOnly = true;
            colEstadoValor.Visible = false;
            colEstadoValor.Width = 125;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 120;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 550);
            Controls.Add(labelTituloDetalle);
            Controls.Add(labelDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(labelEstado);
            Controls.Add(cboEstado);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(labelTituloLista);
            Controls.Add(labelBuscarPor);
            Controls.Add(cboBusqueda);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(dgvData);
            Name = "frmCategoria";
            Text = "Categorías";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ======= VARIABLES =======
        private MaterialLabel labelTituloDetalle;
        private MaterialLabel labelDescripcion;
        private MaterialLabel labelEstado;
        private MaterialLabel labelTituloLista;
        private MaterialLabel labelBuscarPor;

        private TextBox txtDescripcion;
        private ComboBox cboEstado;
        private TextBox txtBusqueda;
        private ComboBox cboBusqueda;
        private TextBox txtIndice;
        private TextBox txtId;

        private IconButton btnGuardar;
        private IconButton btnLimpiar;
        private IconButton btnEliminar;
        private IconButton btnBuscar;
        private IconButton btnLimpiarBuscador;

        private DataGridView dgvData;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colEstadoValor;
        private DataGridViewTextBoxColumn colEstado;
    }
}
