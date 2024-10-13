using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace VenzlArtSystem
{
	public partial class VenderProductos : Form
	{
		private static Clientes Cliente = new Clientes();
		private static List<Articulos> AgregarVenta = new List<Articulos>();
		private static List<DateTime> DevolverArticulos = new List<DateTime>();
		private static List<int> Cantidades = new List<int>();
		private static List<float> Precios = new List<float>();
		private static float PrecioTotal;
		private static string MetododePago;
		
		public VenderProductos()
		{
			InitializeComponent();
			RellenarData();
			Colecciones MostrarDocumento = new Colecciones();
			LblDocumento.Text = "Documento Nro: " + (MostrarDocumento.ListaDeVentas.Count + 1).ToString();
		}
		
		public void AgregarArticuloVenta(Articulos Articulo)
		{
			if(Articulo.cantidadarticulo != 0)
			{
				if(Articulo.disponibilidadarticulo)
				{
					AgregarVenta.Add(Articulo);
					Cantidades.Add(1);
					Precios.Add(Articulo.precioarticulo);
					RellenarData();
				}
				else
				{
					MensajeAviso Mensaje = new MensajeAviso();
					Mensaje.MensajeBox("Este articulo no está disponible");
				}
			}
			else
			{
				MensajeAviso Mensaje = new MensajeAviso();
				Mensaje.MensajeBox("No hay existencia de este articulo");
			}
		}
		
		public void AgregarClienteVenta(Clientes Comprador)
		{
			Cliente = Comprador;
			RellenarData();
		}
		
		private void RellenarData()
		{
			DatosVenta.Rows.Clear();
			PrecioTotal = 0;
			for(int i = 0; i < AgregarVenta.Count; i++)
			{
				int a = DatosVenta.Rows.Add();
				DatosVenta.Rows[a].Cells[0].Value = AgregarVenta[i].codigoarticulo;
				DatosVenta.Rows[a].Cells[1].Value = AgregarVenta[i].tituloarticulo;
				DatosVenta.Rows[a].Cells[2].Value = AgregarVenta[i].descripcionarticulo;
				DatosVenta.Rows[a].Cells[3].Value = AgregarVenta[i].precioarticulo.ToString("C2", CultureInfo.CurrentCulture);
				DatosVenta.Rows[a].Cells[4].Value = AgregarVenta[i].diasprestamo;
				DatosVenta.Rows[a].Cells[5].Value = Cantidades[i].ToString();
				DatosVenta.Rows[a].Cells[6].Value = Precios[i].ToString("C2", CultureInfo.CurrentCulture);
			}
			for(int i = 0; i < Precios.Count; i++)
			{
				PrecioTotal += Precios[i];
			}
			LblTotal.Text = PrecioTotal.ToString("C2", CultureInfo.CurrentCulture);
			LblCedulaC.Text = "Cedula: " + Cliente.Cedula;
			LblNombreC.Text = Cliente.Nombre;
			LblApellidoC.Text = Cliente.Apellido;	
			LblTelefonoC.Text = Cliente.TelefonoMovil;
		}
		
		private void AgregarCantidad()
		{
			Colecciones Coleccion = new Colecciones();
			string CeldaSeleccionada;
			int Posicion;
			Posicion = DatosVenta.CurrentRow.Index;
			
			CeldaSeleccionada = DatosVenta.Rows[DatosVenta.CurrentRow.Index].Cells[0].Value.ToString();
			for(int i = 0; i < Coleccion.ListaDeArticulos.Count; i++)
			{
				if(CeldaSeleccionada == Coleccion.ListaDeArticulos[i].codigoarticulo)
				{
					if(Coleccion.ListaDeArticulos[i].cantidadarticulo < Convert.ToInt32(TxtCantidad.Value))
					{
					   	Cantidades[Posicion] = Coleccion.ListaDeArticulos[i].cantidadarticulo;
				   		MensajeAviso Mensaje = new MensajeAviso();
				   		Mensaje.MensajeBox("No hay la suficiente cantidad de este articulo, se ingreso lo maximo que hay en existencia.", "Aviso");
					}
					else
					{
						Cantidades[Posicion] = Convert.ToInt32(TxtCantidad.Value);
					}
				}
			}
			
			Precios[Posicion] = AgregarVenta[Posicion].precioarticulo * Cantidades[Posicion];
			TxtCantidad.Value = 1;
			RellenarData();
		}
		
		private void QuitarArticulo()
		{
			int Posicion;
			Posicion = DatosVenta.CurrentRow.Index;
			Cantidades.RemoveAt(Posicion);
			AgregarVenta.RemoveAt(Posicion);
			Precios.RemoveAt(Posicion);
			RellenarData();
		}
		
		private void MostrarDescripcionDGV()
		{
			int Ubicacion = DatosVenta.CurrentRow.Index;
			
			LblTipo.Text = "Tipo: " + AgregarVenta[Ubicacion].tipoarticulo;
			LblFabricado.Text = "Fabricado: " + AgregarVenta[Ubicacion].fabricacionarticulo;
			LblFechaIngreso.Text = "Ingresado el: " + AgregarVenta[Ubicacion].fechaingresoarticulo;
			LblExistencia.Text = "Existencias: " + AgregarVenta[Ubicacion].cantidadarticulo.ToString();
		}
		
		private void BorrarListas()
		{
			Cliente = new Clientes();
			AgregarVenta.Clear();
			DevolverArticulos.Clear();
			Cantidades.Clear();
			Precios.Clear();
			PrecioTotal = 0.0f;
		}
		
		private void RestarCantidades(Colecciones Coleccion)
		{
			for(int i = 0; i < Coleccion.ListaDeArticulos.Count; i++)
			{
				for(int j = 0; j < AgregarVenta.Count; j++)
				{
					if(AgregarVenta[j].codigoarticulo == Coleccion.ListaDeArticulos[i].codigoarticulo)
					{
						Coleccion.ListaDeArticulos[i].cantidadarticulo -= Cantidades[j];
					}
				}
			}
		}
		
		private void LlenarListaDevolucion()
		{
			DateTime Fecha;
			for(int i = 0; i < AgregarVenta.Count; i++)
			{
				Fecha = DateTime.Now.AddDays(Convert.ToDouble(AgregarVenta[i].diasprestamo));
				DevolverArticulos.Add(Fecha);
			}
		}
		
		private void Facturar()
		{
			int validacion = ValidarVenta();
			if(validacion == 3)
			{
				FormaPago Pagar = new FormaPago();
				Pagar.ShowDialog();
				MetododePago = Pagar.FormadePago;
				if(MetododePago != "Regresar")
				{
					Colecciones Coleccion = new Colecciones();
					
					LlenarListaDevolucion();
					RestarCantidades(Coleccion);
					
					Coleccion.AgregarVenta(Cliente, AgregarVenta, DevolverArticulos, Cantidades, Precios, PrecioTotal, DateTime.Now, MetododePago, (Coleccion.ListaDeVentas.Count + 1));
					
					MensajeAviso Mensaje = new MensajeAviso();
					Mensaje.MensajeBox("Venta realizada exitosamente");
					BorrarListas();
					RellenarData();
				}
			}
			if(validacion == 2)
			{
				MensajeAviso Mensaje = new MensajeAviso();
				Mensaje.MensajeBox("Por favor ingrese un cliente");
			}
			if(validacion == 1)
			{
				MensajeAviso Mensaje = new MensajeAviso();
				Mensaje.MensajeBox("No hay articulos para facturar");
			}
			if(validacion == 0)
			{
				MensajeAviso Mensaje = new MensajeAviso();
				Mensaje.MensajeBox("No hay articulos ni cliente para facturar");
			}
		}
		
		private int ValidarVenta()
		{
			if(AgregarVenta.Count == 0 && Cliente.Nombre == "Desconocido") return 0;
			if(AgregarVenta.Count == 0) return 1;
			if(Cliente.Nombre == "Desconocido") return 2;
			return 3;
		}
	
		private bool AgregarCodigo()
		{
			Colecciones Coleccion = new Colecciones();
			for(int i = 0; i < Coleccion.ListaDeArticulos.Count; i++)
			{
				if(Coleccion.ListaDeArticulos[i].codigoarticulo == TxtCodigo.Text)
				{
					AgregarArticuloVenta(Coleccion.ListaDeArticulos[i]);
					return true;
				}
			}
			return false;
		}
		
		void BotonBuscarClick(object sender, EventArgs e)
		{
			Inventario Buscar = new Inventario();
			Buscar.Modo_Inventario.Text = "Vender Articulo";
			Buscar.ShowDialog();
			Dispose();
		}
		
		void BotonCantidadClick(object sender, EventArgs e)
		{
			if(DatosVenta.Rows.Count != 0)
			{
				AgregarCantidad();
			}
		}
		
		void BotonEliminarClick(object sender, EventArgs e)
		{
			if(DatosVenta.Rows.Count != 0)
			{
				QuitarArticulo();
			}
		}
		
		void BotonClienteClick(object sender, EventArgs e)
		{
			AgendaClientes Buscar = new AgendaClientes();
			Buscar.Modo_Cliente.Text = "Venta al Cliente";
			Buscar.ShowDialog();
			Dispose();
		}
		
		void BotonFacturarClick(object sender, EventArgs e)
		{
			Facturar();
		}
		
		void BotonCerrarClick(object sender, EventArgs e)
		{
			MensajeAviso Mensaje = new MensajeAviso();
			Mensaje.MensajeBox("¿Seguro deseas salir?", "¡Aviso!", "Si", "No");
			if(Mensaje.MensajeResultado == "Si")
			{
				BorrarListas();
				Dispose();
			}
		}
		
		void TxtCodigoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtCodigoLeave(object sender, EventArgs e)
		{
			if(!AgregarCodigo())
			{
				MensajeAviso Mensaje = new MensajeAviso();
				Mensaje.MensajeBox("No existe ese codigo en el inventario", "Aviso");
			}
			TxtCodigo.Text = "";
		}
		
		void DatosVentaCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if(DatosVenta.Rows.Count != 0)
			{
				MostrarDescripcionDGV();
			}
		}
		
		void IntervalosTick(object sender, EventArgs e)
		{
			LblTiempo.Text = DateTime.Now.ToLongDateString() + "  ";
			LblTiempo.Text += DateTime.Now.ToLongTimeString();
		}
		
		
	}
}
