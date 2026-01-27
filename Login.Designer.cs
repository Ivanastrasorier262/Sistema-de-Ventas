namespace CapaPresentacion
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtdocumento = new TextBox();
            txtclave = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btningresar = new FontAwesome.Sharp.IconButton();
            btncancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LightBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 450);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 261);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 1;
            label2.Text = "SISTEMA DE VENTAS";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.LightBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 118;
            iconPictureBox1.Location = new Point(40, 102);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(118, 118);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(383, 59);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(301, 27);
            txtdocumento.TabIndex = 3;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(383, 141);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(301, 27);
            txtclave.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 35);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Nro Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 118);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.LightSeaGreen;
            btningresar.Cursor = Cursors.Hand;
            btningresar.FlatAppearance.BorderColor = Color.Black;
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.ForeColor = Color.White;
            btningresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btningresar.IconColor = Color.White;
            btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btningresar.IconSize = 21;
            btningresar.Location = new Point(383, 240);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(94, 29);
            btningresar.TabIndex = 7;
            btningresar.Text = "Ingresar";
            btningresar.TextAlign = ContentAlignment.MiddleRight;
            btningresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += iconButton1_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.DarkRed;
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.ForeColor = Color.White;
            btncancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btncancelar.IconColor = Color.White;
            btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncancelar.IconSize = 21;
            btncancelar.Location = new Point(620, 240);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(94, 29);
            btncancelar.TabIndex = 8;
            btncancelar.Text = "Cancelar";
            btncancelar.TextAlign = ContentAlignment.MiddleRight;
            btncancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btncancelar);
            Controls.Add(btningresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtclave);
            Controls.Add(txtdocumento);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtdocumento;
        private TextBox txtclave;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btningresar;
        private FontAwesome.Sharp.IconButton btncancelar;
    }
}