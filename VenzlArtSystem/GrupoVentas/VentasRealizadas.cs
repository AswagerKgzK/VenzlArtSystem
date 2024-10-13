using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace VenzlArtSystem
{
	public partial class VentasRealizadas : Form
	{
		public VentasRealizadas()
		{
			InitializeComponent();
			LlenarTodo();
		}
		
		private void LlenarTodo()
		{
			Colecciones Buscar = new Colecciones();
			DatosVentas.Rows.Clear();
			for(int i = 0; i < Buscar.ListaDeVentas.Count; i++)
			{
				LlenarDataGrid(i, Buscar);
			}
		}
		
		private void SeleccionarVenta()
		{
			string CeldaSeleccionada;
			if(DatosVentas.Rows.Count != 0)
			{
				CeldaSeleccionada = DatosVentas.Rows[DatosVentas.CurrentRow.Index].Cells[0].Value.ToString();
				Colecciones VerFactura = new Colecciones();
				
				for(int i = 0; i < VerFactura.ListaDeVentas.Count; i++)
				{
					if(CeldaSeleccionada == VerFactura.ListaDeVentas[i].CodigoVentaProductos.ToString())
					{
						Factura Ver = new Factura();
						Ver.RecibirDatos(VerFactura.ListaDeVentas[i]);
					}
				}
				
			}
		}
		
		private void MostrarFecha()
		{
			DateTime FechaBusqueda;
			
			try{
				FechaBusqueda = Convert.ToDateTime(TxtFecha.Text);
			}catch{
				MensajeAviso Mensaje = new MensajeAviso();
				Mensaje.MensajeBox("Ingrese una fecha valida");
				return;}
			
			Colecciones Buscar = new Colecciones();
			DatosVentas.Rows.Clear();
			for(int i = 0; i < Buscar.ListaDeVentas.Count; i++)
			{
				if(FechaBusqueda.ToShortDateString() == Buscar.ListaDeVentas[i].Realizado.ToShortDateString())
				{
					LlenarDataGrid(i, Buscar);
				}
			}
			TxtFecha.Text = "";
		}
		
		private void VerGanancias()
		{
			float TotalGanancias = 0.0f;
			DateTime FechaBusqueda;
			
			try{
				FechaBusqueda = Convert.ToDateTime(TxtFecha.Text);
			}catch{
				MensajeAviso Mensaje = new MensajeAviso();
				Mensaje.MensajeBox("Ingrese una fecha valida");
			return;}
			
			Colecciones Buscar = new Colecciones();
			for(int i = 0; i < Buscar.ListaDeVentas.Count; i++)
			{
				if(FechaBusqueda.ToShortDateString() == Buscar.ListaDeVentas[i].Realizado.ToShortDateString())
				{
					TotalGanancias += Buscar.ListaDeVentas[i].PrecioTotal;
				}
			}
			MensajeAviso Mensaje2 = new MensajeAviso();
			Mensaje2.MensajeBox("El dia: " + FechaBusqueda.ToShortDateString() + " se ha hecho un total de: " + TotalGanancias.ToString("C2", CultureInfo.CurrentCulture), "Ganancias", "Cerrar");
		}
		
		private void LlenarDataGrid(int i, Colecciones Coleccion)
		{
			int a = DatosVentas.Rows.Add();
			DatosVentas.Rows[a].Cells[0].Value = Coleccion.ListaDeVentas[i].CodigoVentaProductos.ToString();
			DatosVentas.Rows[a].Cells[1].Value = Coleccion.ListaDeVentas[i].Cliente.Cedula;
			DatosVentas.Rows[a].Cells[2].Value = Coleccion.ListaDeVentas[i].Cliente.Nombre + " " + Coleccion.ListaDeVentas[i].Cliente.Apellido;
			DatosVentas.Rows[a].Cells[3].Value = Coleccion.ListaDeVentas[i].Cliente.TelefonoMovil;
			DatosVentas.Rows[a].Cells[4].Value = Coleccion.ListaDeVentas[i].PrecioTotal.ToString("C2", CultureInfo.CurrentCulture);
			DatosVentas.Rows[a].Cells[5].Value = Coleccion.ListaDeVentas[i].Realizado.ToShortDateString();
		}
		
		void BotonCerrarClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void BotonMostrarFechaClick(object sender, EventArgs e)
		{
			MostrarFecha();
		}
		
		void BotonVerGananciasClick(object sender, EventArgs e)
		{
			VerGanancias();
		}
		
		void BotonMostrarTodoClick(object sender, EventArgs e)
		{
			LlenarTodo();
		}
		
		void DatosVentasCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			SeleccionarVenta();
		}
	
		void TxtFechaKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				MostrarFecha();
				TxtFecha.Text = "";
				SendKeys.Send("{TAB}");
			}
		}
	}
}
