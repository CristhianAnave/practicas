﻿using ClnLicoreria2024;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpLicoreria2024
{
	public partial class FrmDetalleCompra : Form
	{
		public FrmDetalleCompra()
		{
			InitializeComponent();
			btnDescargarPdf.Click += btnDescargarPdf_Click;
			// Configurar el DataGridView
			dgvDetalles.Columns.Add("idProducto", "ID Producto");
			dgvDetalles.Columns.Add("codigo", "Código");
			dgvDetalles.Columns.Add("nombre", "Nombre");
			dgvDetalles.Columns.Add("precioCompra", "Precio de Compra");
			dgvDetalles.Columns.Add("precioVenta", "Precio de Venta");
			dgvDetalles.Columns.Add("cantidad", "Cantidad");
			dgvDetalles.Columns.Add("total", "Total");
		}




		private void btnBuscarNFactura_Click(object sender, EventArgs e)
		{
			string numeroDocumento = txtNFacturaBoleta.Text.Trim();
			if (string.IsNullOrEmpty(numeroDocumento))
			{
				MessageBox.Show("Por favor, ingrese un número de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var compra = CompraCln.ObtenerCompraPorNumeroDocumento(numeroDocumento);
			if (compra != null)
			{
				// Llenar los TextBox con la información de la compra
				txtTipoDocumento.Text = compra.tipoDocumento;
				txtUsuario.Text = compra.usuarioRegistro;
				txtFecha.Text = compra.fechaRegistro.ToString("dd/MM/yyyy");
				
				// Obtener los detalles de la compra
				var detalles = DetalleCompraCln.ObtenerDetallesPorIdCompra(compra.id);
				dgvDetalles.Rows.Clear();
				if (detalles.Count == 0)
				{
					MessageBox.Show("No se encontraron detalles para esta compra.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					foreach (var detalle in detalles)
					{
						dgvDetalles.Rows.Add(detalle.idProducto, detalle.codigo, detalle.nombre, detalle.precioCompra, detalle.precioVenta, detalle.cantidad, detalle.total);
					}
				}

				// Obtener y mostrar la razón social del proveedor
				var proveedor = ProveedorCln.ObtenerProveedorPorId(compra.idProveedor);
				txtDocuProveedor.Text = proveedor?.documento ?? "Proveedor no encontrado";
				txtRazonSocial.Text = proveedor?.razonSocial ?? "Proveedor no encontrado";
				//calcular y mostrar el total a pagar
				CalcularTotalPagar();
			}
			else
			{
				MessageBox.Show("Compra no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void CalcularTotalPagar()
		{
			decimal totalPagar = 0;

			foreach (DataGridViewRow row in dgvDetalles.Rows)
			{
				// Asegúrate de que la fila no sea una fila de nuevo
				if (row.Cells["total"].Value != null)
				{
					totalPagar += Convert.ToDecimal(row.Cells["Total"].Value);
				}
			}

			// Mostrar el total en el TextBox
			txtTotalPagar.Text = totalPagar.ToString("0.00"); // Formato con dos decimales
		}





		private void btnDescargarPdf_Click(object sender, EventArgs e)
		{
			// Crear un nuevo documento
			Document doc = new Document();

			// Especificar la ruta del archivo PDF
			string ruta = "DetallesCompra.pdf";

			try
			{
				// Inicializar el escritor
				PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
				doc.Open();

				// Agregar un título
				doc.Add(new Paragraph("Detalles de Compra"));
				doc.Add(new Paragraph(DateTime.Now.ToString()));

				// Crear una tabla con el número de columnas
				PdfPTable table = new PdfPTable(dgvDetalles.Columns.Count);

				// Agregar encabezados
				foreach (DataGridViewColumn column in dgvDetalles.Columns)
				{
					table.AddCell(column.HeaderText);
				}

				// Agregar filas
				foreach (DataGridViewRow row in dgvDetalles.Rows)
				{
					foreach (DataGridViewCell cell in row.Cells)
					{
						table.AddCell(cell.Value?.ToString());
					}
				}

				// Agregar la tabla al documento
				doc.Add(table);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al exportar a PDF: {ex.Message}");
			}
			finally
			{
				// Cerrar el documento
				doc.Close();
				MessageBox.Show($"PDF exportado a {ruta}");
			}
		}

		
	} 
	
}
