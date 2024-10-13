using System;
using System.Drawing;
using System.Windows.Forms;

namespace VenzlArtSystem
{
	public partial class AgregarArticulo : Form
	{
		public AgregarArticulo()
		{
			InitializeComponent();
		}
		
		private void Agregar_Modificar()
		{
			if(Validar() == true)
			{
				Colecciones Coleccion = new Colecciones();
				Colecciones Buscar = new Colecciones();
				for (int i = 0; i < Coleccion.ListaDeArticulos.Count; i++)
				{
					if(txtCodigo.Text == Coleccion.ListaDeArticulos[i].codigoarticulo)
					{
						MensajeAviso Mensaje = new MensajeAviso();
						Mensaje.MensajeBox("¿Este código ya existe, desea actualizarlo?", "¡Atencion!", "Si", "No");
						if(Mensaje.MensajeResultado == "Si")
						{
							Buscar.ModificarProducto(i, TxtArticulo.Text.Trim(), TxtTitulo.Text.Trim(), TxtTipo.Text.Trim(), TxtFechaF.Text, Convert.ToSingle(TxtPrecio.Text), ChBoxDisponible.Checked, Convert.ToInt32(TxtDias.Text));
							LimpiarTextos();
						}
						return;
					}
				}
				Buscar.AgregarArticulo(txtCodigo.Text.Trim(), TxtArticulo.Text.Trim(), TxtTitulo.Text.Trim(), TxtTipo.Text.Trim(), Convert.ToSingle(TxtPrecio.Text), 0, TxtFechaF.Text, ChBoxDisponible.Checked, Convert.ToInt32(TxtDias.Text));
				LimpiarTextos();
				return;
			}
		}
		
		private void Rellenar()
		{
			Colecciones Coleccion = new Colecciones();
			for (int i = 0; i < Coleccion.ListaDeArticulos.Count; i++) {
				if(Coleccion.ListaDeArticulos[i].codigoarticulo == txtCodigo.Text)
				{
					TxtArticulo.Text = Coleccion.ListaDeArticulos[i].tituloarticulo;
					TxtTitulo.Text = Coleccion.ListaDeArticulos[i].descripcionarticulo;
					TxtTipo.Text = Coleccion.ListaDeArticulos[i].tipoarticulo;
					TxtFechaF.Text = Coleccion.ListaDeArticulos[i].fabricacionarticulo.ToString();
					TxtPrecio.Text = Coleccion.ListaDeArticulos[i].precioarticulo.ToString("G");
					TxtDias.Text = Coleccion.ListaDeArticulos[i].diasprestamo.ToString();
					ChBoxDisponible.Checked = Coleccion.ListaDeArticulos[i].disponibilidadarticulo;
					LblAgregado.Text = Coleccion.ListaDeArticulos[i].fechaingresoarticulo;
					LblFijo.Visible = true;
					LblAgregado.Visible = true;
					return;
				}
			}
			return;
		}
	
		private void LimpiarTextos()
		{
			txtCodigo.Text = "";
			TxtArticulo.Text = "";
			TxtTitulo.Text = "";
			TxtTipo.Text = "";
			TxtFechaF.Text = "";
			TxtPrecio.Text = "";
			TxtDias.Text = "";
			ChBoxDisponible.Checked = false;
			LblFijo.Visible = false;
			LblAgregado.Visible = false;
			ReiniciarColores();
		}
		
		private void ReiniciarColores()
		{
			txtCodigo.BackColor = Color.White;
			TxtArticulo.BackColor = Color.White;
			TxtTitulo.BackColor = Color.White;
			TxtTipo.BackColor = Color.White;
			TxtFechaF.BackColor = Color.White;
			TxtPrecio.BackColor = Color.White;
			TxtDias.BackColor = Color.White;
		}
		
		private void MostrarErrores(bool a, bool b, bool c, bool d, bool e, bool f, bool g)
		{
			ReiniciarColores();
			if(!a) txtCodigo.BackColor = Color.Pink;
			if(!b) TxtArticulo.BackColor = Color.Pink;
			if(!c) TxtTitulo.BackColor = Color.Pink;
			if(!d) TxtTipo.BackColor = Color.Pink;
			if(!e) TxtFechaF.BackColor = Color.Pink;
			if(!f) TxtPrecio.BackColor = Color.Pink;
			if(!g) TxtDias.BackColor = Color.Pink;
		}
		
		private bool Validar()
		{
			bool v1, v2, v3, v4, v5, v6, v7;
			
			ValidarTextos Validar = new ValidarTextos();
			ReiniciarColores();
			
			v1 = Validar.ValidacionCodigo(txtCodigo.Text);
			v2 = Validar.ValidacionVacio(TxtArticulo.Text);
			v3 = Validar.ValidacionVacio(TxtTitulo.Text);
			v4 = Validar.ValidacionVacio(TxtTipo.Text);
			v5 = Validar.ValidacionFechas(TxtFechaF.Text);
			v6 = Validar.ValidacionNumerica(TxtPrecio.Text);
			v7 = Validar.ValidacionNumerosEnteros(TxtDias.Text);
			
			if(v1 && v2 && v3 && v4 && v5 && v6 && v7)
			{
				return true;
			}
			else
			{
				MostrarErrores(v1, v2, v3, v4, v5, v6, v7);
			}
			MensajeAviso mensaje = new MensajeAviso();
			mensaje.MensajeBox("Por favor ingrese los datos validos.", "Aviso");
			return false;
		}
	
		void BotonBuscarClick(object sender, EventArgs e)
		{
			Dispose();
			Inventario BuscarInventario = new Inventario();
			BuscarInventario.Modo_Inventario.Text = "Buscar Articulo";
			BuscarInventario.Show();
		}
			
		void BotonAgregar_ActualizarClick(object sender, EventArgs e)
		{
			Agregar_Modificar();
		}
			
		void BotonReiniciarClick(object sender, EventArgs e)
		{
			LimpiarTextos();
		}
	
		void BotonCerrarClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void TxtCodigoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				Rellenar();
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtCodigoLeave(object sender, EventArgs e)
		{
			Rellenar();
		}
		
		void TxtArticuloKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtTituloKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtTipoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtFechaFKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtPrecioKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtDiasKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
	}
}
