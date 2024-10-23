﻿namespace CpLicoreria2024
{
    partial class FrmCategoria
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
			this.txtParametroCategoria = new System.Windows.Forms.TextBox();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
			this.lblDescripcionCategoria = new System.Windows.Forms.Label();
			this.dgvListaCategoria = new System.Windows.Forms.DataGridView();
			this.erpDescripcionCategoria = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaCategoria)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDescripcionCategoria)).BeginInit();
			this.SuspendLayout();
			// 
			// txtParametroCategoria
			// 
			this.txtParametroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtParametroCategoria.Location = new System.Drawing.Point(485, 35);
			this.txtParametroCategoria.Margin = new System.Windows.Forms.Padding(4);
			this.txtParametroCategoria.Name = "txtParametroCategoria";
			this.txtParametroCategoria.Size = new System.Drawing.Size(249, 24);
			this.txtParametroCategoria.TabIndex = 105;
			this.txtParametroCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametroCategoria_KeyPress);
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.BackColor = System.Drawing.Color.White;
			this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBusqueda.Location = new System.Drawing.Point(310, 40);
			this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(179, 25);
			this.lblBusqueda.TabIndex = 104;
			this.lblBusqueda.Text = "Buscar por Descripción :";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(15, 10);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(170, 20);
			this.lblTitulo.TabIndex = 101;
			this.lblTitulo.Text = "Detalle de Categorias";
			// 
			// txtDescripcionCategoria
			// 
			this.txtDescripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcionCategoria.Location = new System.Drawing.Point(19, 67);
			this.txtDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4);
			this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
			this.txtDescripcionCategoria.Size = new System.Drawing.Size(224, 24);
			this.txtDescripcionCategoria.TabIndex = 95;
			// 
			// lblDescripcionCategoria
			// 
			this.lblDescripcionCategoria.BackColor = System.Drawing.Color.Transparent;
			this.lblDescripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescripcionCategoria.Location = new System.Drawing.Point(16, 40);
			this.lblDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
			this.lblDescripcionCategoria.Size = new System.Drawing.Size(169, 23);
			this.lblDescripcionCategoria.TabIndex = 94;
			this.lblDescripcionCategoria.Text = "Nombre de Categoría:";
			// 
			// dgvListaCategoria
			// 
			this.dgvListaCategoria.AllowUserToAddRows = false;
			this.dgvListaCategoria.AllowUserToDeleteRows = false;
			this.dgvListaCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvListaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaCategoria.Location = new System.Drawing.Point(266, 93);
			this.dgvListaCategoria.Margin = new System.Windows.Forms.Padding(4);
			this.dgvListaCategoria.Name = "dgvListaCategoria";
			this.dgvListaCategoria.ReadOnly = true;
			this.dgvListaCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListaCategoria.Size = new System.Drawing.Size(681, 223);
			this.dgvListaCategoria.TabIndex = 93;
			// 
			// erpDescripcionCategoria
			// 
			this.erpDescripcionCategoria.ContainerControl = this;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.Image = global::CpLicoreria2024.Properties.Resources.limpiar;
			this.btnLimpiar.Location = new System.Drawing.Point(846, 24);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(101, 51);
			this.btnLimpiar.TabIndex = 120;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Image = global::CpLicoreria2024.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(741, 24);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(99, 51);
			this.btnBuscar.TabIndex = 119;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevo.Image = global::CpLicoreria2024.Properties.Resources.Nuevo;
			this.btnNuevo.Location = new System.Drawing.Point(19, 151);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(102, 51);
			this.btnNuevo.TabIndex = 118;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Image = global::CpLicoreria2024.Properties.Resources.editar;
			this.btnEditar.Location = new System.Drawing.Point(141, 208);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(102, 51);
			this.btnEditar.TabIndex = 117;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Image = global::CpLicoreria2024.Properties.Resources.eliminar;
			this.btnEliminar.Location = new System.Drawing.Point(19, 265);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(102, 51);
			this.btnEliminar.TabIndex = 116;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Image = global::CpLicoreria2024.Properties.Resources.cerrar;
			this.btnCerrar.Location = new System.Drawing.Point(141, 265);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(102, 51);
			this.btnCerrar.TabIndex = 115;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.Image = global::CpLicoreria2024.Properties.Resources.Guardar;
			this.btnGuardar.Location = new System.Drawing.Point(19, 208);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(102, 51);
			this.btnGuardar.TabIndex = 114;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.BackColor = System.Drawing.Color.White;
			this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(264, 7);
			this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(761, 79);
			this.lblSubtitulo.TabIndex = 102;
			this.lblSubtitulo.Text = "Lista de Categorias:";
			// 
			// FrmCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(954, 327);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtParametroCategoria);
			this.Controls.Add(this.lblBusqueda);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.txtDescripcionCategoria);
			this.Controls.Add(this.lblDescripcionCategoria);
			this.Controls.Add(this.dgvListaCategoria);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmCategoria";
			this.Text = "::: Licoreria - Categoria :::";
			this.Load += new System.EventHandler(this.FrmCategoria_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaCategoria)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDescripcionCategoria)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtParametroCategoria;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.DataGridView dgvListaCategoria;
        private System.Windows.Forms.ErrorProvider erpDescripcionCategoria;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblSubtitulo;
	}
}