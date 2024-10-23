﻿namespace CpLicoreria2024
{
    partial class FrmEmpleado
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
			this.components = new System.ComponentModel.Container();
			this.txtSegundoApellido = new System.Windows.Forms.TextBox();
			this.txtParametroEmpleado = new System.Windows.Forms.TextBox();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.txtPrimerApellido = new System.Windows.Forms.TextBox();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.lblRazonSocial = new System.Windows.Forms.Label();
			this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
			this.lblDocumento = new System.Windows.Forms.Label();
			this.dgvListaEmpleado = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxCargo = new System.Windows.Forms.ComboBox();
			this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNombres = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpApellidos = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDireccion = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombres)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSegundoApellido
			// 
			this.txtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSegundoApellido.Location = new System.Drawing.Point(20, 191);
			this.txtSegundoApellido.Name = "txtSegundoApellido";
			this.txtSegundoApellido.Size = new System.Drawing.Size(210, 22);
			this.txtSegundoApellido.TabIndex = 80;
			// 
			// txtParametroEmpleado
			// 
			this.txtParametroEmpleado.Location = new System.Drawing.Point(453, 39);
			this.txtParametroEmpleado.Name = "txtParametroEmpleado";
			this.txtParametroEmpleado.Size = new System.Drawing.Size(265, 20);
			this.txtParametroEmpleado.TabIndex = 79;
			this.txtParametroEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametroEmpleado_KeyPress);
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.BackColor = System.Drawing.Color.White;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(249, 9);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(690, 85);
			this.lblSubtitulo.TabIndex = 78;
			this.lblSubtitulo.Text = "Lista de Empleados:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(16, 12);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(175, 20);
			this.lblTitulo.TabIndex = 77;
			this.lblTitulo.Text = "Detalle de Empleados";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.BackColor = System.Drawing.SystemColors.Control;
			this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefono.Location = new System.Drawing.Point(17, 172);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(118, 16);
			this.lblTelefono.TabIndex = 76;
			this.lblTelefono.Text = "Segundo Apellido:";
			// 
			// txtPrimerApellido
			// 
			this.txtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrimerApellido.Location = new System.Drawing.Point(20, 147);
			this.txtPrimerApellido.Name = "txtPrimerApellido";
			this.txtPrimerApellido.Size = new System.Drawing.Size(210, 22);
			this.txtPrimerApellido.TabIndex = 75;
			// 
			// lblCorreo
			// 
			this.lblCorreo.AutoSize = true;
			this.lblCorreo.BackColor = System.Drawing.SystemColors.Control;
			this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorreo.Location = new System.Drawing.Point(17, 128);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(102, 16);
			this.lblCorreo.TabIndex = 74;
			this.lblCorreo.Text = "Primer Apellido:";
			// 
			// txtNombres
			// 
			this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombres.Location = new System.Drawing.Point(20, 103);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(210, 22);
			this.txtNombres.TabIndex = 73;
			// 
			// lblRazonSocial
			// 
			this.lblRazonSocial.AutoSize = true;
			this.lblRazonSocial.BackColor = System.Drawing.SystemColors.Control;
			this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRazonSocial.Location = new System.Drawing.Point(17, 84);
			this.lblRazonSocial.Name = "lblRazonSocial";
			this.lblRazonSocial.Size = new System.Drawing.Size(66, 16);
			this.lblRazonSocial.TabIndex = 72;
			this.lblRazonSocial.Text = "Nombres:";
			// 
			// txtCedulaIdentidad
			// 
			this.txtCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedulaIdentidad.Location = new System.Drawing.Point(20, 59);
			this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
			this.txtCedulaIdentidad.Size = new System.Drawing.Size(210, 22);
			this.txtCedulaIdentidad.TabIndex = 71;
			// 
			// lblDocumento
			// 
			this.lblDocumento.AutoSize = true;
			this.lblDocumento.BackColor = System.Drawing.SystemColors.Control;
			this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocumento.Location = new System.Drawing.Point(17, 40);
			this.lblDocumento.Name = "lblDocumento";
			this.lblDocumento.Size = new System.Drawing.Size(131, 16);
			this.lblDocumento.TabIndex = 70;
			this.lblDocumento.Text = "Cédula de Identidad:";
			// 
			// dgvListaEmpleado
			// 
			this.dgvListaEmpleado.AllowUserToAddRows = false;
			this.dgvListaEmpleado.AllowUserToDeleteRows = false;
			this.dgvListaEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvListaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaEmpleado.Location = new System.Drawing.Point(249, 102);
			this.dgvListaEmpleado.Name = "dgvListaEmpleado";
			this.dgvListaEmpleado.ReadOnly = true;
			this.dgvListaEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListaEmpleado.Size = new System.Drawing.Size(690, 433);
			this.dgvListaEmpleado.TabIndex = 69;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Location = new System.Drawing.Point(1, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(242, 549);
			this.label1.TabIndex = 68;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccion.Location = new System.Drawing.Point(20, 235);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(210, 22);
			this.txtDireccion.TabIndex = 89;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 88;
			this.label2.Text = "Dirección:";
			// 
			// txtCelular
			// 
			this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCelular.Location = new System.Drawing.Point(20, 279);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(210, 22);
			this.txtCelular.TabIndex = 91;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 260);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 16);
			this.label3.TabIndex = 90;
			this.label3.Text = "Celular:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 317);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 16);
			this.label4.TabIndex = 92;
			this.label4.Text = "Cargo:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(81, 342);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(121, 22);
			this.txtUsuario.TabIndex = 95;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 348);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 16);
			this.label5.TabIndex = 94;
			this.label5.Text = "Usuario:";
			// 
			// cbxCargo
			// 
			this.cbxCargo.FormattingEnabled = true;
			this.cbxCargo.Items.AddRange(new object[] {
            "Propietario",
            "Empleado",
            "Guardia De seguridad",
            "Contador"});
			this.cbxCargo.Location = new System.Drawing.Point(81, 312);
			this.cbxCargo.Name = "cbxCargo";
			this.cbxCargo.Size = new System.Drawing.Size(121, 21);
			this.cbxCargo.TabIndex = 96;
			// 
			// erpCedulaIdentidad
			// 
			this.erpCedulaIdentidad.ContainerControl = this;
			// 
			// erpNombres
			// 
			this.erpNombres.ContainerControl = this;
			// 
			// erpApellidos
			// 
			this.erpApellidos.ContainerControl = this;
			// 
			// erpDireccion
			// 
			this.erpDireccion.ContainerControl = this;
			// 
			// erpCelular
			// 
			this.erpCelular.ContainerControl = this;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.Image = global::CpLicoreria2024.Properties.Resources.limpiar;
			this.btnLimpiar.Location = new System.Drawing.Point(829, 23);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(101, 51);
			this.btnLimpiar.TabIndex = 127;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Image = global::CpLicoreria2024.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(724, 23);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(99, 51);
			this.btnBuscar.TabIndex = 126;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevo.Image = global::CpLicoreria2024.Properties.Resources.Nuevo;
			this.btnNuevo.Location = new System.Drawing.Point(12, 375);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(102, 51);
			this.btnNuevo.TabIndex = 125;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Image = global::CpLicoreria2024.Properties.Resources.editar;
			this.btnEditar.Location = new System.Drawing.Point(134, 432);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(102, 51);
			this.btnEditar.TabIndex = 124;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Image = global::CpLicoreria2024.Properties.Resources.eliminar;
			this.btnEliminar.Location = new System.Drawing.Point(12, 489);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(102, 51);
			this.btnEliminar.TabIndex = 123;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Image = global::CpLicoreria2024.Properties.Resources.cerrar;
			this.btnCerrar.Location = new System.Drawing.Point(134, 489);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(102, 51);
			this.btnCerrar.TabIndex = 122;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.Image = global::CpLicoreria2024.Properties.Resources.Guardar;
			this.btnGuardar.Location = new System.Drawing.Point(12, 432);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(102, 51);
			this.btnGuardar.TabIndex = 121;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// FrmEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(951, 547);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.cbxCargo);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCelular);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSegundoApellido);
			this.Controls.Add(this.txtParametroEmpleado);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.txtPrimerApellido);
			this.Controls.Add(this.lblCorreo);
			this.Controls.Add(this.txtNombres);
			this.Controls.Add(this.lblRazonSocial);
			this.Controls.Add(this.txtCedulaIdentidad);
			this.Controls.Add(this.lblDocumento);
			this.Controls.Add(this.dgvListaEmpleado);
			this.Controls.Add(this.label1);
			this.Name = "FrmEmpleado";
			this.Text = "::: Licoreria - Empleado :::";
			this.Load += new System.EventHandler(this.FrmEmpleado_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombres)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtParametroEmpleado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtCedulaIdentidad;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.DataGridView dgvListaEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
        private System.Windows.Forms.ErrorProvider erpNombres;
        private System.Windows.Forms.ErrorProvider erpApellidos;
        private System.Windows.Forms.ErrorProvider erpDireccion;
        private System.Windows.Forms.ErrorProvider erpCelular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnGuardar;
	}
}