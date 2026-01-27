namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            menuStrip2 = new MenuStrip();
            menuusuario = new FontAwesome.Sharp.IconMenuItem();
            menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            manuventas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            verdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            manucompras = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            menuclientes = new FontAwesome.Sharp.IconMenuItem();
            menuproveedor = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            menuacercade = new FontAwesome.Sharp.IconMenuItem();
            menutitulo = new MenuStrip();
            label1 = new Label();
            label2 = new Label();
            contenedor = new Panel();
            lblusuario = new Label();
            label4 = new Label();
            label3 = new Label();
            menuStrip2.SuspendLayout();
            contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Location = new Point(0, 156);
            menu.Name = "menu";
            menu.Size = new Size(1274, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            menu.ItemClicked += menu_ItemClicked;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ButtonHighlight;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { menuusuario, menumantenedor, manuventas, manucompras, menuclientes, menuproveedor, menureportes, menuacercade });
            menuStrip2.Location = new Point(0, 78);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1274, 78);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuusuario
            // 
            menuusuario.AutoSize = false;
            menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            menuusuario.IconColor = Color.Black;
            menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuusuario.IconSize = 50;
            menuusuario.ImageScaling = ToolStripItemImageScaling.None;
            menuusuario.Name = "menuusuario";
            menuusuario.Size = new Size(80, 74);
            menuusuario.Text = "Usuarios";
            menuusuario.TextImageRelation = TextImageRelation.ImageAboveText;
            menuusuario.Click += menuusuario_Click;
            // 
            // menumantenedor
            // 
            menumantenedor.AutoSize = false;
            menumantenedor.DropDownItems.AddRange(new ToolStripItem[] { submenucategoria, submenuproducto });
            menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            menumantenedor.IconColor = Color.Black;
            menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menumantenedor.IconSize = 50;
            menumantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menumantenedor.Name = "menumantenedor";
            menumantenedor.Size = new Size(152, 74);
            menumantenedor.Text = "Mantenedor";
            menumantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenucategoria
            // 
            submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            submenucategoria.IconColor = Color.Black;
            submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenucategoria.Name = "submenucategoria";
            submenucategoria.Size = new Size(157, 26);
            submenucategoria.Text = "Categoria";
            submenucategoria.Click += submenucategoria_Click;
            // 
            // submenuproducto
            // 
            submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuproducto.IconColor = Color.Black;
            submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuproducto.Name = "submenuproducto";
            submenuproducto.Size = new Size(157, 26);
            submenuproducto.Text = "Producto";
            submenuproducto.Click += submenuproducto_Click;
            // 
            // manuventas
            // 
            manuventas.AutoSize = false;
            manuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarventa, verdetalleventa });
            manuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            manuventas.IconColor = Color.Black;
            manuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            manuventas.IconSize = 50;
            manuventas.ImageScaling = ToolStripItemImageScaling.None;
            manuventas.Name = "manuventas";
            manuventas.Size = new Size(80, 74);
            manuventas.Text = "Ventas";
            manuventas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarventa
            // 
            submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrarventa.IconColor = Color.Black;
            submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrarventa.Name = "submenuregistrarventa";
            submenuregistrarventa.Size = new Size(165, 26);
            submenuregistrarventa.Text = "Registrar";
            submenuregistrarventa.Click += submenuregistrarventa_Click;
            // 
            // verdetalleventa
            // 
            verdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            verdetalleventa.IconColor = Color.Black;
            verdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            verdetalleventa.Name = "verdetalleventa";
            verdetalleventa.Size = new Size(165, 26);
            verdetalleventa.Text = "Ver Detalle";
            verdetalleventa.Click += verdetalleventa_Click;
            // 
            // manucompras
            // 
            manucompras.AutoSize = false;
            manucompras.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarcompra, submenuverdetallecompra });
            manucompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            manucompras.IconColor = Color.Black;
            manucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            manucompras.IconSize = 50;
            manucompras.ImageScaling = ToolStripItemImageScaling.None;
            manucompras.Name = "manucompras";
            manucompras.Size = new Size(152, 74);
            manucompras.Text = "Compras ";
            manucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            manucompras.Click += iconMenuItem4_Click;
            // 
            // submenuregistrarcompra
            // 
            submenuregistrarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrarcompra.IconColor = Color.Black;
            submenuregistrarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrarcompra.Name = "submenuregistrarcompra";
            submenuregistrarcompra.Size = new Size(165, 26);
            submenuregistrarcompra.Text = "Registrar";
            submenuregistrarcompra.Click += submenuregistrarcompra_Click;
            // 
            // submenuverdetallecompra
            // 
            submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuverdetallecompra.IconColor = Color.Black;
            submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuverdetallecompra.Name = "submenuverdetallecompra";
            submenuverdetallecompra.Size = new Size(165, 26);
            submenuverdetallecompra.Text = "Ver Detalle";
            submenuverdetallecompra.Click += submenuverdetallecompra_Click;
            // 
            // menuclientes
            // 
            menuclientes.AutoSize = false;
            menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            menuclientes.IconColor = Color.Black;
            menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuclientes.IconSize = 50;
            menuclientes.ImageScaling = ToolStripItemImageScaling.None;
            menuclientes.Name = "menuclientes";
            menuclientes.Size = new Size(80, 74);
            menuclientes.Text = "Clientes";
            menuclientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuclientes.Click += menuclientes_Click;
            // 
            // menuproveedor
            // 
            menuproveedor.AutoSize = false;
            menuproveedor.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            menuproveedor.IconColor = Color.Black;
            menuproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuproveedor.IconSize = 50;
            menuproveedor.ImageScaling = ToolStripItemImageScaling.None;
            menuproveedor.Name = "menuproveedor";
            menuproveedor.Size = new Size(80, 74);
            menuproveedor.Text = "Proveedores";
            menuproveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            menuproveedor.Click += menuproveedor_Click;
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.IconSize = 50;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(80, 74);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            menureportes.Click += menureportes_Click;
            // 
            // menuacercade
            // 
            menuacercade.AutoSize = false;
            menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuacercade.IconColor = Color.Black;
            menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuacercade.IconSize = 50;
            menuacercade.ImageScaling = ToolStripItemImageScaling.None;
            menuacercade.Name = "menuacercade";
            menuacercade.Size = new Size(80, 74);
            menuacercade.Text = "Acerca de ";
            menuacercade.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menutitulo
            // 
            menutitulo.AutoSize = false;
            menutitulo.BackColor = Color.LightBlue;
            menutitulo.ImageScalingSize = new Size(20, 20);
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.RightToLeft = RightToLeft.Yes;
            menutitulo.Size = new Size(1274, 78);
            menutitulo.TabIndex = 2;
            menutitulo.Text = "menuStrip3";
            menutitulo.ItemClicked += menuStrip3_ItemClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 194);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Location = new Point(68, 278);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            label2.Click += label2_Click;
            // 
            // contenedor
            // 
            contenedor.Controls.Add(lblusuario);
            contenedor.Controls.Add(label4);
            contenedor.Controls.Add(label3);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 180);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1274, 339);
            contenedor.TabIndex = 5;
            contenedor.Paint += contenedor_Paint;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = Color.LightBlue;
            lblusuario.Location = new Point(1196, 14);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(78, 20);
            lblusuario.TabIndex = 2;
            lblusuario.Text = "Iblusuario ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightBlue;
            label4.Location = new Point(1121, 14);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 1;
            label4.Text = "Usuario: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 44);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 0;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 519);
            Controls.Add(contenedor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menu);
            Controls.Add(menuStrip2);
            Controls.Add(menutitulo);
            MainMenuStrip = menu;
            Name = "Inicio";
            Text = "Form1";
            Load += Inicio_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menuStrip2;
        private MenuStrip menutitulo;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem manuventas;
        private FontAwesome.Sharp.IconMenuItem manucompras;
        private FontAwesome.Sharp.IconMenuItem menuproveedor;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private Panel contenedor;
        private Label label3;
        private Label label4;
        private Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem verdetalleventa;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
    }
}
