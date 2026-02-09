namespace CapaPresentacion
{
    partial class frmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
            btnselaccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            textbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            label12 = new Label();
            txtId = new TextBox();
            label11 = new Label();
            txtIndice = new TextBox();
            label10 = new Label();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            cboEstado = new ComboBox();
            cboCategoria = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtDescripcion = new TextBox();
            label6 = new Label();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label13 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 175);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.White;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 16;
            btnbuscar.Location = new Point(1122, 99);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(30, 29);
            btnbuscar.TabIndex = 55;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnselaccionar, id, Codigo, Nombre, Descripcion, idCategoria, Categoria, Stock, PrecioCompra, PrecioVenta, EstadoValor, Estado });
            dgvData.Location = new Point(420, 186);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(830, 466);
            dgvData.TabIndex = 49;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnselaccionar
            // 
            btnselaccionar.HeaderText = "";
            btnselaccionar.MinimumWidth = 6;
            btnselaccionar.Name = "btnselaccionar";
            btnselaccionar.ReadOnly = true;
            btnselaccionar.Text = "✔";
            btnselaccionar.UseColumnTextForButtonValue = true;
            btnselaccionar.Width = 30;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Visible = false;
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 125;
            // 
            // idCategoria
            // 
            idCategoria.HeaderText = "idCategoria";
            idCategoria.MinimumWidth = 6;
            idCategoria.Name = "idCategoria";
            idCategoria.ReadOnly = true;
            idCategoria.Visible = false;
            idCategoria.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 125;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.BackColor = Color.White;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.Black;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.Black;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 18;
            btnlimpiarbuscador.Location = new Point(1177, 99);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(30, 31);
            btnlimpiarbuscador.TabIndex = 56;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click_1;
            // 
            // textbusqueda
            // 
            textbusqueda.Location = new Point(951, 102);
            textbusqueda.Name = "textbusqueda";
            textbusqueda.Size = new Size(147, 27);
            textbusqueda.TabIndex = 54;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(778, 101);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(148, 28);
            cbobusqueda.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(690, 109);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 52;
            label12.Text = "Buscar por:";
            // 
            // txtId
            // 
            txtId.Location = new Point(314, 119);
            txtId.Name = "txtId";
            txtId.Size = new Size(26, 27);
            txtId.TabIndex = 51;
            txtId.Text = "0";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(420, 79);
            label11.Name = "label11";
            label11.Size = new Size(830, 98);
            label11.TabIndex = 50;
            label11.Text = "Lista de Productos:\r\n";
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(248, 119);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(27, 27);
            txtIndice.TabIndex = 57;
            txtIndice.Text = "-1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 81);
            label10.Name = "label10";
            label10.Size = new Size(255, 35);
            label10.TabIndex = 48;
            label10.Text = "Detalle del Producto";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.OrangeRed;
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = Color.Black;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.ForeColor = Color.White;
            btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btneliminar.IconColor = Color.White;
            btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminar.IconSize = 16;
            btneliminar.Location = new Point(40, 616);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(192, 29);
            btneliminar.TabIndex = 47;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click_1;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.SteelBlue;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiar.IconColor = Color.White;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 18;
            btnlimpiar.Location = new Point(40, 565);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(192, 31);
            btnlimpiar.TabIndex = 46;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.SeaGreen;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardar.IconColor = Color.White;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 16;
            btnguardar.Location = new Point(40, 520);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(192, 29);
            btnguardar.TabIndex = 45;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(43, 429);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 44;
            label9.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(40, 452);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(189, 28);
            cboEstado.TabIndex = 43;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(40, 385);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(189, 28);
            cboCategoria.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(43, 362);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 41;
            label8.Text = "Categoria:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(40, 286);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 39;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(40, 298);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(189, 27);
            txtDescripcion.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(43, 265);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 37;
            label6.Text = "Descripcion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 224);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 27);
            txtNombre.TabIndex = 35;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(43, 171);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(189, 27);
            txtCodigo.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 81);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(43, 201);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 31;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(40, 148);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 30;
            label2.Text = "Codigo";
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Dock = DockStyle.Left;
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(3, 64);
            label13.Name = "label13";
            label13.Size = new Size(411, 588);
            label13.TabIndex = 29;
            label13.Click += label13_Click;
            // 
            // button1
            // 
            button1.Location = new Point(462, 132);
            button1.Name = "button1";
            button1.Size = new Size(178, 29);
            button1.TabIndex = 58;
            button1.Text = "Descargar Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 655);
            Controls.Add(button1);
            Controls.Add(btnbuscar);
            Controls.Add(dgvData);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(textbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label12);
            Controls.Add(txtId);
            Controls.Add(label11);
            Controls.Add(txtIndice);
            Controls.Add(label10);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(label9);
            Controls.Add(cboEstado);
            Controls.Add(cboCategoria);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtDescripcion);
            Controls.Add(label6);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(label1);
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox textbusqueda;
        private ComboBox cbobusqueda;
        private Label label12;
        private TextBox txtId;
        private Label label11;
        private TextBox txtIndice;
        private Label label10;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label label9;
        private ComboBox cboEstado;
        private ComboBox cboCategoria;
        private Label label8;
        private Label label7;
        private TextBox txtDescripcion;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label13;
        private DataGridViewButtonColumn btnselaccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private Button button1;
    }
}