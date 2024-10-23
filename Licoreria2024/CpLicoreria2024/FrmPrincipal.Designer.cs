﻿namespace CpLicoreria2024
{
    partial class FrmPrincipal
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
			this.label1 = new System.Windows.Forms.Label();
			this.menuTitulo = new System.Windows.Forms.MenuStrip();
			this.menuUsuario = new FontAwesome.Sharp.IconMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
			this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.negocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
			this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
			this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.verDetalleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
			this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
			this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
			this.reportesVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAcercade = new FontAwesome.Sharp.IconMenuItem();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.label2 = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(95, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 31);
			this.label1.TabIndex = 6;
			this.label1.Text = "Licoreria JUANITO";
			// 
			// menuTitulo
			// 
			this.menuTitulo.AutoSize = false;
			this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.menuTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.menuTitulo.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuMantenedor,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuAcercade});
			this.menuTitulo.Location = new System.Drawing.Point(0, 85);
			this.menuTitulo.Name = "menuTitulo";
			this.menuTitulo.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuTitulo.Size = new System.Drawing.Size(1172, 161);
			this.menuTitulo.TabIndex = 4;
			this.menuTitulo.Text = "menuStrip1";
			// 
			// menuUsuario
			// 
			this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem});
			this.menuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
			this.menuUsuario.IconColor = System.Drawing.Color.Black;
			this.menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuUsuario.IconSize = 70;
			this.menuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuUsuario.Name = "menuUsuario";
			this.menuUsuario.Size = new System.Drawing.Size(83, 159);
			this.menuUsuario.Text = "Usuarios";
			this.menuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
			// 
			// menuMantenedor
			// 
			this.menuMantenedor.AutoSize = false;
			this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.negocioToolStripMenuItem});
			this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
			this.menuMantenedor.IconColor = System.Drawing.Color.Black;
			this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuMantenedor.IconSize = 70;
			this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuMantenedor.Name = "menuMantenedor";
			this.menuMantenedor.Size = new System.Drawing.Size(157, 153);
			this.menuMantenedor.Text = "Mantenedor";
			this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// categoriaToolStripMenuItem
			// 
			this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
			this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
			this.categoriaToolStripMenuItem.Text = "Categoria";
			this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
			// 
			// productoToolStripMenuItem
			// 
			this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
			this.productoToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
			this.productoToolStripMenuItem.Text = "Producto";
			this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
			// 
			// negocioToolStripMenuItem
			// 
			this.negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
			this.negocioToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
			this.negocioToolStripMenuItem.Text = "Negocio";
			this.negocioToolStripMenuItem.Click += new System.EventHandler(this.negocioToolStripMenuItem_Click);
			// 
			// menuVentas
			// 
			this.menuVentas.AutoSize = false;
			this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.verDetalleToolStripMenuItem});
			this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
			this.menuVentas.IconColor = System.Drawing.Color.Black;
			this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuVentas.IconSize = 70;
			this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuVentas.Name = "menuVentas";
			this.menuVentas.Size = new System.Drawing.Size(157, 153);
			this.menuVentas.Text = "Ventas";
			this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// registrarToolStripMenuItem
			// 
			this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
			this.registrarToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
			this.registrarToolStripMenuItem.Text = "Registrar";
			this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
			// 
			// verDetalleToolStripMenuItem
			// 
			this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
			this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
			this.verDetalleToolStripMenuItem.Text = "Ver Detalle";
			// 
			// menuCompras
			// 
			this.menuCompras.AutoSize = false;
			this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.verDetalleToolStripMenuItem1});
			this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
			this.menuCompras.IconColor = System.Drawing.Color.Black;
			this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuCompras.IconSize = 70;
			this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuCompras.Name = "menuCompras";
			this.menuCompras.Size = new System.Drawing.Size(157, 153);
			this.menuCompras.Text = "Compras";
			this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// registrarToolStripMenuItem1
			// 
			this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
			this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
			this.registrarToolStripMenuItem1.Text = "Registrar";
			this.registrarToolStripMenuItem1.Click += new System.EventHandler(this.registrarToolStripMenuItem1_Click);
			// 
			// verDetalleToolStripMenuItem1
			// 
			this.verDetalleToolStripMenuItem1.Name = "verDetalleToolStripMenuItem1";
			this.verDetalleToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
			this.verDetalleToolStripMenuItem1.Text = "Ver Detalle";
			this.verDetalleToolStripMenuItem1.Click += new System.EventHandler(this.verDetalleToolStripMenuItem1_Click);
			// 
			// menuClientes
			// 
			this.menuClientes.AutoSize = false;
			this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
			this.menuClientes.IconColor = System.Drawing.Color.Black;
			this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuClientes.IconSize = 70;
			this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuClientes.Name = "menuClientes";
			this.menuClientes.Size = new System.Drawing.Size(157, 153);
			this.menuClientes.Text = "Clientes";
			this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
			// 
			// menuProveedores
			// 
			this.menuProveedores.AutoSize = false;
			this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
			this.menuProveedores.IconColor = System.Drawing.Color.Black;
			this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuProveedores.IconSize = 70;
			this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuProveedores.Name = "menuProveedores";
			this.menuProveedores.Size = new System.Drawing.Size(157, 153);
			this.menuProveedores.Text = "Proveedores";
			this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
			// 
			// menuReportes
			// 
			this.menuReportes.AutoSize = false;
			this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesVentasToolStripMenuItem,
            this.reportesComprasToolStripMenuItem});
			this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
			this.menuReportes.IconColor = System.Drawing.Color.Black;
			this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuReportes.IconSize = 70;
			this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuReportes.Name = "menuReportes";
			this.menuReportes.Size = new System.Drawing.Size(122, 153);
			this.menuReportes.Text = "Reportes";
			this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// reportesVentasToolStripMenuItem
			// 
			this.reportesVentasToolStripMenuItem.Name = "reportesVentasToolStripMenuItem";
			this.reportesVentasToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
			this.reportesVentasToolStripMenuItem.Text = "Reportes Ventas";
			// 
			// reportesComprasToolStripMenuItem
			// 
			this.reportesComprasToolStripMenuItem.Name = "reportesComprasToolStripMenuItem";
			this.reportesComprasToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
			this.reportesComprasToolStripMenuItem.Text = "Reportes Compras";
			this.reportesComprasToolStripMenuItem.Click += new System.EventHandler(this.reportesComprasToolStripMenuItem_Click);
			// 
			// menuAcercade
			// 
			this.menuAcercade.AutoSize = false;
			this.menuAcercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
			this.menuAcercade.IconColor = System.Drawing.Color.Black;
			this.menuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuAcercade.IconSize = 70;
			this.menuAcercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuAcercade.Name = "menuAcercade";
			this.menuAcercade.Size = new System.Drawing.Size(157, 153);
			this.menuAcercade.Text = "Acerca de";
			this.menuAcercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// menu
			// 
			this.menu.AutoSize = false;
			this.menu.BackColor = System.Drawing.Color.Black;
			this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.menu.Size = new System.Drawing.Size(1172, 85);
			this.menu.TabIndex = 5;
			this.menu.Text = "menuStrip2";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(918, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 24);
			this.label2.TabIndex = 9;
			this.label2.Text = "Usuario:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblUsuario
			// 
			this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUsuario.BackColor = System.Drawing.Color.White;
			this.lblUsuario.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(1011, 9);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(142, 56);
			this.lblUsuario.TabIndex = 8;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Black;
			this.pictureBox2.Image = global::CpLicoreria2024.Properties.Resources.Logo_removebg_preview1;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(89, 85);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::CpLicoreria2024.Properties.Resources.cerveza_vaso_984x666;
			this.pictureBox1.Location = new System.Drawing.Point(0, 246);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1172, 241);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1172, 487);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuTitulo);
			this.Controls.Add(this.menu);
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "::: Licoreria - Principal :::";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			this.menuTitulo.ResumeLayout(false);
			this.menuTitulo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negocioToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem reportesVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesComprasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuAcercade;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}