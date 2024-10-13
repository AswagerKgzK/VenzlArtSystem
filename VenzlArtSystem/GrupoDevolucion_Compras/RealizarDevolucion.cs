using System;
using System.Drawing;
using System.Windows.Forms;

namespace VenzlArtSystem
{
	public partial class RealizarDevolucion : Form
	{
		Articulos ArticuloDevolucion;
		
		public RealizarDevolucion()
		{
			InitializeComponent();
			Colecciones x = new Colecciones();
			Refrescar(x);
		}
		
		public void ColocarArticulo(int i, Colecciones Coleccion)
		{
			ArticuloDevolucion = Coleccion.ListaDeArticulos[i];
			LblNombreArticulo.Text = "";
			LblNombreArticulo.Text = Coleccion.ListaDeArticulos[i].tituloarticulo + "\n";
			LblNombreArticulo.Text += Coleccion.ListaDeArticulos[i].tipoarticulo + "\n";
			LblNombreArticulo.Text += Coleccion.ListaDeArticulos[i].fabricacionarticulo + "\n";
			LblNombreArticulo.Text += "Existencias: " + Coleccion.ListaDeArticulos[i].cantidadarticulo.ToString() + "\n";
			LblNombreArticulo.Text += Coleccion.ListaDeArticulos[i].descripcionarticulo;
		}
		
		private void RegistrarDevolucion()
		{
			Colecciones Registrar = new Colecciones();
			for(int i = 0; i < Registrar.ListaDeArticulos.Count; i++)
			{
				if(Registrar.ListaDeArticulos[i].codigoarticulo == ArticuloDevolucion.codigoarticulo)
				{
					Registrar.ListaDeArticulos[i].cantidadarticulo += Convert.ToInt32(TxtCantidad.Text);
				}
			}
			Registrar.AgregarDevolucion(ArticuloDevolucion, Convert.ToInt32(TxtCantidad.Text), DateTime.Now, ComboTipo.Text, (Registrar.ListaDeDevolucion.Count + 1));
			
			MensajeAviso Mensaje = new MensajeAviso();
			Mensaje.MensajeBox(ComboTipo.Text + " realizada correctamente");
			Refrescar(Registrar);
		}
		
		private void Refrescar(Colecciones Registrar)
		{
			TxtCantidad.Text = "";
			ComboTipo.Text = "";
			LblDocumento.Text = "Documento Nro. " + (Registrar.ListaDeDevolucion.Count + 1).ToString();
			LblNombreArticulo.Text = "";
		}
		
		private bool BuscarArticulo()
		{
			Colecciones Coleccion = new Colecciones();
			for(int i = 0; i < Coleccion.ListaDeArticulos.Count; i++)
			{
				if(Coleccion.ListaDeArticulos[i].codigoarticulo == TxtCodigo.Text)
				{
					ColocarArticulo(i, Coleccion);
					return true;
				}
			}
			return false;
		}
		
		private bool Verificacion()
		{
			bool a, b;
			
			ValidarTextos Validar = new ValidarTextos();
			a = Validar.ValidacionNumerosEnteros(TxtCantidad.Text);
			b = Validar.ValidacionVacio(ComboTipo.Text);
			
			if(a && b && ArticuloDevolucion != null)
			{
				return true;
			}
			MensajeAviso Mensaje = new MensajeAviso();
			Mensaje.MensajeBox("Ingrese los datos para registrar", "Aviso");
			return false;
		}
		
		void BotonBuscarClick(object sender, EventArgs e)
		{
			Dispose();
			Inventario Buscar = new Inventario();
			Buscar.Modo_Inventario.Text = "Recibir Articulo";
			Buscar.Show();
		}
		
		void BotonCloseClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void BotonRegistrarClick(object sender, EventArgs e)
		{
			if(Verificacion())
			{
				RegistrarDevolucion();
			}
		}
	
		void TxtCodigoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				if(!BuscarArticulo())
				{
					MensajeAviso Mensaje = new MensajeAviso();
					Mensaje.MensajeBox("No existe ese codigo en el inventario", "Aviso");
				}
				TxtCodigo.Text = "";
				SendKeys.Send("{TAB}");
			}
		}
		
	}
}
