namespace CapaPresentacion
{
    partial class frmUsuarios
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            label6 = new Label();
            txtConfirmarClave = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cboEstado = new ComboBox();
            label9 = new Label();
            cboRol = new ComboBox();
            txtDocumento = new TextBox();
            txtNombre = new TextBox();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btneliminar = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            dgvData = new DataGridView();
            btnselaccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label11 = new Label();
            txtId = new TextBox();
            label12 = new Label();
            cbobusqueda = new ComboBox();
            textbusqueda = new TextBox();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtIndice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 64);
            label1.Name = "label1";
            label1.Size = new Size(452, 661);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(66, 125);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Nro de Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(69, 178);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(66, 231);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 150);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            label5.Click += label5_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(66, 254);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(230, 27);
            txtCorreo.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(66, 316);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(230, 27);
            txtClave.TabIndex = 9;
            txtClave.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(66, 293);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 8;
            label6.Text = "Contraseña:";
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(69, 378);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.PasswordChar = '*';
            txtConfirmarClave.Size = new Size(230, 27);
            txtConfirmarClave.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(69, 355);
            label7.Name = "label7";
            label7.Size = new Size(160, 20);
            label7.TabIndex = 10;
            label7.Text = "Confirmar Contraseña: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(70, 408);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 12;
            label8.Text = "Rol:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(66, 501);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(230, 28);
            cboEstado.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(66, 478);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 15;
            label9.Text = "Estado:";
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(66, 431);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(230, 28);
            cboRol.TabIndex = 13;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(69, 148);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(230, 27);
            txtDocumento.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 201);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 27);
            txtNombre.TabIndex = 6;
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
            btnguardar.Location = new Point(66, 559);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(233, 29);
            btnguardar.TabIndex = 16;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
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
            btnlimpiar.Location = new Point(66, 611);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(233, 31);
            btnlimpiar.TabIndex = 17;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
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
            btneliminar.Location = new Point(66, 666);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(233, 29);
            btneliminar.TabIndex = 18;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(46, 64);
            label10.Name = "label10";
            label10.Size = new Size(237, 35);
            label10.TabIndex = 19;
            label10.Text = "Detalle del Usuario";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnselaccionar, id, Documento, NombreCompleto, Correo, Clave, idRol, Rol, EstadoValor, Estado });
            dgvData.Location = new Point(461, 201);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(871, 466);
            dgvData.TabIndex = 20;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnselaccionar
            // 
            btnselaccionar.HeaderText = "";
            btnselaccionar.MinimumWidth = 6;
            btnselaccionar.Name = "btnselaccionar";
            btnselaccionar.ReadOnly = true;
            btnselaccionar.Width = 30;
            // 
            // id
            // 
            id.HeaderText = "idUsuario";
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
            Documento.Visible = false;
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
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 6;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Width = 125;
            // 
            // idRol
            // 
            idRol.HeaderText = "idRol";
            idRol.MinimumWidth = 6;
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            idRol.Visible = false;
            idRol.Width = 125;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 125;
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
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(461, 72);
            label11.Name = "label11";
            label11.Size = new Size(825, 98);
            label11.TabIndex = 21;
            label11.Text = "Lista de Usuarios:\r\n";
            // 
            // txtId
            // 
            txtId.Location = new Point(359, 97);
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 27);
            txtId.TabIndex = 22;
            txtId.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(720, 104);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 23;
            label12.Text = "Buscar por:";
            label12.Click += label12_Click;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(828, 101);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(99, 28);
            cbobusqueda.TabIndex = 24;
            // 
            // textbusqueda
            // 
            textbusqueda.Location = new Point(947, 101);
            textbusqueda.Name = "textbusqueda";
            textbusqueda.Size = new Size(142, 27);
            textbusqueda.TabIndex = 25;
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
            btnlimpiarbuscador.Location = new Point(1186, 97);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(71, 31);
            btnlimpiarbuscador.TabIndex = 27;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
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
            btnbuscar.Location = new Point(1109, 97);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(71, 29);
            btnbuscar.TabIndex = 26;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(299, 97);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(35, 27);
            txtIndice.TabIndex = 28;
            txtIndice.Text = "-1";
            txtIndice.TextChanged += textBox4_TextChanged_1;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1415, 728);
            Controls.Add(txtIndice);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(textbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label12);
            Controls.Add(txtId);
            Controls.Add(label11);
            Controls.Add(dgvData);
            Controls.Add(label10);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(label9);
            Controls.Add(cboEstado);
            Controls.Add(cboRol);
            Controls.Add(label8);
            Controls.Add(txtConfirmarClave);
            Controls.Add(label7);
            Controls.Add(txtClave);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtDocumento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private Label label6;
        private TextBox txtConfirmarClave;
        private Label label7;
        private Label label8;
        private ComboBox cboEstado;
        private Label label9;
        private ComboBox cboRol;
        private TextBox txtDocumento;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private Label label10;
        private DataGridView dgvData;
        private Label label11;
        private TextBox txtId;
        private Label label12;
        private ComboBox cbobusqueda;
        private TextBox textbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private DataGridViewButtonColumn btnselaccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txtIndice;
    }
}