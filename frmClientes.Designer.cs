namespace CapaPresentacion
{
    partial class frmClientes
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
            btnbuscar = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
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
            txtTelefono = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnselaccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
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
            btnbuscar.Location = new Point(1144, 123);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(71, 29);
            btnbuscar.TabIndex = 55;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.White;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnselaccionar, id, Documento, NombreCompleto, Correo, Telefono, EstadoValor, Estado });
            dgvData.Location = new Point(474, 204);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(871, 466);
            dgvData.TabIndex = 49;
            dgvData.CellContentClick += dgvData_CellContentClick;
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
            btnlimpiarbuscador.Location = new Point(1247, 121);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(71, 31);
            btnlimpiarbuscador.TabIndex = 56;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // textbusqueda
            // 
            textbusqueda.Location = new Point(968, 120);
            textbusqueda.Name = "textbusqueda";
            textbusqueda.Size = new Size(142, 27);
            textbusqueda.TabIndex = 54;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(845, 119);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(99, 28);
            cbobusqueda.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(720, 123);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 52;
            label12.Text = "Buscar por:";
            // 
            // txtId
            // 
            txtId.Location = new Point(332, 95);
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 27);
            txtId.TabIndex = 51;
            txtId.Text = "0";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(474, 86);
            label11.Name = "label11";
            label11.Size = new Size(871, 98);
            label11.TabIndex = 50;
            label11.Text = "Lista de Clientes:";
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(266, 94);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(35, 27);
            txtIndice.TabIndex = 57;
            txtIndice.Text = "-1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 86);
            label10.Name = "label10";
            label10.Size = new Size(224, 35);
            label10.TabIndex = 48;
            label10.Text = "Detalle de Cliente";
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
            btneliminar.Location = new Point(12, 604);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(233, 29);
            btneliminar.TabIndex = 47;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
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
            btnlimpiar.Location = new Point(12, 547);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(233, 31);
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
            btnguardar.Location = new Point(9, 497);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(233, 29);
            btnguardar.TabIndex = 45;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(15, 404);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 44;
            label9.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(9, 427);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(230, 28);
            cboEstado.TabIndex = 43;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(6, 358);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(230, 27);
            txtTelefono.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(12, 320);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 37;
            label6.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 263);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(230, 27);
            txtCorreo.TabIndex = 36;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 210);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 27);
            txtNombre.TabIndex = 35;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(15, 157);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(230, 27);
            txtDocumento.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 123);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 240);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 32;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(15, 187);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 31;
            label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 30;
            label2.Text = "Nro de Documento";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 64);
            label1.Name = "label1";
            label1.Size = new Size(452, 622);
            label1.TabIndex = 29;
            // 
            // btnselaccionar
            // 
            btnselaccionar.HeaderText = "";
            btnselaccionar.MinimumWidth = 6;
            btnselaccionar.Name = "btnselaccionar";
            btnselaccionar.ReadOnly = true;
            btnselaccionar.Width = 30;
            btnselaccionar.Text = "✔";
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
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 125;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
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
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 689);
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
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtDocumento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmClientes";
            Text = "frmClientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnselaccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}