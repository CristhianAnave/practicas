﻿using CadLicoreria2024;
using ClnLicoreria2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpLicoreria2024
{
    public partial class FrmEmpleado : Form
    {
        private bool esNuevo = false;
        public FrmEmpleado()
        {
            InitializeComponent();
        }
        public void listar()
        {
            var lista = EmpleadoCln.listarPa(txtParametroEmpleado.Text);
            dgvListaEmpleado.DataSource = lista;
            dgvListaEmpleado.Columns["id"].Visible = false;
            dgvListaEmpleado.Columns["idUsuario"].Visible = false;
            //esto es para cambiar los nombres visibles en la tabla
            dgvListaEmpleado.Columns["cedulaIdentidad"].HeaderText = "Cedula de Identidad";
            dgvListaEmpleado.Columns["nombres"].HeaderText = "Nombres";
            dgvListaEmpleado.Columns["primerApellido"].HeaderText = "Primer Apellido";
            dgvListaEmpleado.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
            dgvListaEmpleado.Columns["direccion"].HeaderText = "Dirección";
            dgvListaEmpleado.Columns["celular"].HeaderText = "Celular";
            dgvListaEmpleado.Columns["cargo"].HeaderText = "Cargo";
            dgvListaEmpleado.Columns["usuario"].HeaderText = "Usuario";
            dgvListaEmpleado.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvListaEmpleado.Columns["fechaRegistro"].HeaderText = "Fecha Registro";


            btnEditar.Enabled = lista.Count() > 0;
            btnEliminar.Enabled = lista.Count() > 0;

            if (lista.Count > 0) dgvListaEmpleado.CurrentCell = dgvListaEmpleado.Rows[0].Cells["cedulaIdentidad"];
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            txtNombres.KeyPress += Util.onlyLetters;
            txtPrimerApellido.KeyPress += Util.onlyLetters;
            txtSegundoApellido.KeyPress += Util.onlyLetters;
            txtCelular.KeyPress += Util.onlyNumbers;
            listar();
        }
    
        private void txtParametroEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

		//todo lo de abajo va junto 
		private bool validar()
        {
            bool esValido = true;
            erpCedulaIdentidad.SetError(txtCedulaIdentidad, "");
            erpNombres.SetError(txtNombres, "");
            erpApellidos.SetError(txtPrimerApellido, "");
            erpDireccion.SetError(txtDireccion, "");
            erpCelular.SetError(txtCelular, "");

            // evalua si la cadena esta vacia en el espacio de documento, visebersa para todos los campos 
            if (string.IsNullOrEmpty(txtCedulaIdentidad.Text))
            {
                esValido = false;
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "El campo cedula de identidad es obligatorio");
            }
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                esValido = false;
                erpNombres.SetError(txtNombres, "El campo nombres es obligatorio");
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtSegundoApellido.Text))
            {
                esValido = false;
                erpApellidos.SetError(txtPrimerApellido, "Debe introducir al menos un apellido");
                erpApellidos.SetError(txtSegundoApellido, "Debe introducir al menos un apellido");

            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                esValido = false;
                erpDireccion.SetError(txtDireccion, "El campo direccion es obligatorio");
            }
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                esValido = false;
                erpCelular.SetError(txtCelular, "El campo celular es obligatorio");
            }
            return esValido;
        }

     
		private void limpiar()
        {
            txtCedulaIdentidad.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            cbxCargo.SelectedIndex = -1;
        }
        private void limpiarlista()
        {
            txtParametroEmpleado.Text = string.Empty;
        }

      
        //----------------------------------------------------------------------------------------------------------
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			txtCedulaIdentidad.Focus(); //para que el puntero parpadee en el texto de documento al presionar btnNuevo
			limpiar();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var empleado = new Empleado();
				empleado.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
				empleado.nombres = txtNombres.Text.Trim();
				empleado.primerApellido = txtPrimerApellido.Text.Trim();
				empleado.segundoApellido = txtSegundoApellido.Text.Trim();
				empleado.direccion = txtDireccion.Text.Trim();
				empleado.celular = Convert.ToInt64(txtCelular.Text);
				empleado.cargo = cbxCargo.Text;
				empleado.usuarioRegistro = Util.usuario.usuario1;

				if (esNuevo)
				{
					Usuario usuario = null;
					if (!string.IsNullOrEmpty(txtUsuario.Text))
					{
						usuario = new Usuario();
						usuario.usuario1 = txtUsuario.Text.Trim();
						usuario.clave = Util.Encrypt("hola123");
					}
					empleado.fechaRegistro = DateTime.Now;
					empleado.estado = 1;
					EmpleadoCln.insertar(empleado, usuario);
				}
				else
				{
					int index = dgvListaEmpleado.CurrentCell.RowIndex;
					empleado.id = Convert.ToInt32(dgvListaEmpleado.Rows[index].Cells["id"].Value);
					EmpleadoCln.actualizar(empleado);
				}
				listar();
				MessageBox.Show("Empleado guardado correctamente", ":::Licoreria - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvListaEmpleado.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvListaEmpleado.Rows[index].Cells["id"].Value);
			string cedulaIdentidad = dgvListaEmpleado.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
			DialogResult dialog =
				MessageBox.Show($"¿Está seguro que desea dar de baja al empleado con cedula de identidad {cedulaIdentidad}?",
				"::: Licoreria - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
			{
				EmpleadoCln.eliminar(id, Util.usuario.usuario1);
				listar();
				MessageBox.Show("Empleado dado de baja correctamente", "::: Licoreria - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			int index = dgvListaEmpleado.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvListaEmpleado.Rows[index].Cells["id"].Value);
			var empleado = EmpleadoCln.obtenerUno(id);
			txtCedulaIdentidad.Text = empleado.cedulaIdentidad;
			txtNombres.Text = empleado.nombres;
			txtPrimerApellido.Text = empleado.primerApellido;
			txtSegundoApellido.Text = empleado.segundoApellido;
			txtDireccion.Text = empleado.direccion;
			txtCelular.Text = empleado.celular.ToString();
			cbxCargo.Text = empleado.cargo;
			txtUsuario.Text = empleado.Usuario.Count() > 0 ? empleado.Usuario.First().usuario1 : "";
			txtCedulaIdentidad.Focus();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{

			limpiarlista();
		}
	}
}
