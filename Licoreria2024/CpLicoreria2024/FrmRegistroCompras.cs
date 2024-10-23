using CadLicoreria2024;
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
	public partial class FrmRegistroCompras : Form
	{
		public FrmRegistroCompras()
		{
			InitializeComponent();
		}

		private DataTable ObtenerComprasPorFecha(DateTime fechaInicio, DateTime fechaFin)
		{
			// Crear un DataTable para almacenar los resultados
			DataTable dtResultados = new DataTable();
			dtResultados.Columns.Add("Número de Factura");
			dtResultados.Columns.Add("Fecha");
			dtResultados.Columns.Add("Proveedor");
			dtResultados.Columns.Add("Producto");
			dtResultados.Columns.Add("Cantidad");
			dtResultados.Columns.Add("PrecioCompra");
			dtResultados.Columns.Add("PrecioVenta");
			
			dtResultados.Columns.Add("Monto Total");
			dtResultados.Columns.Add("Total");


			using (var context = new Labsis457licoreriaEntities2())
			{
				// Obtener las compras dentro del rango de fechas
				var compras = context.Compra
				
					.Where(c => c.fechaRegistro >= fechaInicio && c.fechaRegistro <= fechaFin)
					.ToList();

				foreach (var compra in compras)
				{
					// Obtener los detalles asociados a cada compra
					var detalles = context.DetalleCompra
						.Where(dc => dc.idCompra == compra.id)
						.ToList();

					foreach (var detalle in detalles)
					{
						decimal total =(decimal)detalle.precioCompra * (decimal)detalle.cantidad;
						dtResultados.Rows.Add(compra.numeroDocumento, compra.fechaRegistro, compra.Proveedor.razonSocial,
							detalle.Producto.nombre, detalle.cantidad, detalle.Producto.precioCompra, detalle.Producto.precioVenta,
							total, total);
					}
				}
			}

			return dtResultados;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			DateTime fechaInicio = dtpFechaInicio.Value;
			DateTime fechaFin = dtpFechaFin.Value;

			// Asegúrate de que la fecha de inicio sea menor o igual que la fecha de fin
			if (fechaInicio > fechaFin)
			{
				MessageBox.Show("La fecha de inicio debe ser menor o igual que la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Llamar a la función para listar las compras
			var compras = ObtenerComprasPorFecha(fechaInicio, fechaFin);
			dgvRegistro.DataSource = compras;
		}
	}
}
