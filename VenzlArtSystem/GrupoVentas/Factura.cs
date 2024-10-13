using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace VenzlArtSystem
{
	public partial class Factura : Form
	{
		public Factura()
		{
			InitializeComponent();
		}
		
		public void RecibirDatos(Ventas Informacion)
		{
			LCodigo.Text = "Documento nro: " + Informacion.CodigoVentaProductos.ToString();
			LCedula.Text = Informacion.Cliente.Cedula;
			LNombreApellido.Text = Informacion.Cliente.Nombre + " " + Informacion.Cliente.Apellido;
			LCorreo.Text = Informacion.Cliente.CorreoElectronico;
			LDireccion.Text = Informacion.Cliente.Dirrecion;
			LTelefonoM.Text = Informacion.Cliente.TelefonoMovil;
			LTelefonoR.Text = Informacion.Cliente.TelefonoResidencial;
			LFechaEmision.Text = "Emitido: " + Informacion.Realizado.ToShortDateString();
			LModoPago.Text = "Pagado en: " + Informacion.Pagado;
			LTotal.Text = Informacion.PrecioTotal.ToString("C2", CultureInfo.CurrentCulture);
			
			ListaArticulosVendidos(Informacion);
			ShowDialog();
		}
		
		private void ListaArticulosVendidos(Ventas Informacion)
		{
			DatosLista.Rows.Clear();
			for(int i = 0; i < Informacion.CantidadProductos.Count; i++)
			{
				int a = DatosLista.Rows.Add();
				DatosLista.Rows[a].Cells[0].Value = Informacion.ProductosVenta[i].tituloarticulo;
				DatosLista.Rows[a].Cells[1].Value = Informacion.DevolucionProductos[i].ToShortDateString();
				DatosLista.Rows[a].Cells[2].Value = Informacion.CantidadProductos[i].ToString();
				DatosLista.Rows[a].Cells[3].Value = Informacion.PreciosProductos[i].ToString("C2", CultureInfo.CurrentCulture);
			
			}
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
