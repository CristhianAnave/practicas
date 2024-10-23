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
	public partial class FrmVenta : Form
	{
		public FrmVenta()
		{
			InitializeComponent();
		}

		private void btnBuscarProducto_Click(object sender, EventArgs e)
		{
			FrmProductoPequenoVenta productoFrm = new FrmProductoPequenoVenta(this);
			productoFrm.ShowDialog();
		}

		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			FrmPequeCliente clienteFrm = new FrmPequeCliente(this);
			clienteFrm.ShowDialog();
		}

		public void SetProducto2Data(string idProducto, string codigo, string nombre, string stock, string precioVenta) 
		{
			txtIdProducto.Text = idProducto;
			txtCodigoProducto.Text = codigo;
			txtProducto.Text = nombre;
			txtStock.Text = stock;
			txtPrecioVenta .Text = precioVenta;
		}
		public void SetClientePequeData(string idCliente, string documento, string nombreCompleto)
		{
			txtIdCliente.Text = idCliente;
			txtDocuCliente.Text = documento;
			txtNombreCliente.Text = nombreCompleto;


		}
		private void FrmVenta_Load(object sender, EventArgs e)
		{
			txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
			txtIdProducto.Text = "0";
			txtIdCliente.Text = "0";

			dgvVentas.Columns.Add("IdProducto", "ID Producto");
			dgvVentas.Columns.Add("Codigo", "Código");
			dgvVentas.Columns.Add("Nombre", "Nombre");
			dgvVentas.Columns.Add("PrecioVenta", "Precio de Venta");
			dgvVentas.Columns.Add("Cantidad", "Cantidad");
			dgvVentas.Columns.Add("Total", "Total");
		}

		private void ibtnAgregar_Click(object sender, EventArgs e)
		{
			//if (!validar())
			//{
				// Si no es válido, muestra un mensaje y no continúa
				//MessageBox.Show("Por favor, corrige los errores antes de agregar el producto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				//return; // Detiene la ejecución si la validación falla
			//}
			var idProducto = txtIdProducto.Text;
			var codigo = txtCodigoProducto.Text;
			var nombre = txtProducto.Text;			
			var precioVenta = decimal.Parse(txtPrecioVenta.Text);
			var cantidad = int.Parse(nudCantidadVender.Text);
			var total = precioVenta * cantidad;



			// Agregar una nueva fila al DataGridView
			dgvVentas.Rows.Add(idProducto, codigo, nombre, precioVenta, cantidad, total);

			// Limpiar los campos después de agregar
			//LimpiarCampos();
			//CalcularTotalPagar();
		}
	}
}
