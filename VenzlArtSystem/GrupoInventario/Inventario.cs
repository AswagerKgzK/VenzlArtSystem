using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace VenzlArtSystem
{
	public partial class Inventario : Form
	{
		public Inventario()
		{
			InitializeComponent();
			BuscarArticulos();
		}
		
		private void BuscarArticulos()
		{
			Colecciones Coleccion = new Colecciones();
			DataArticulos.Rows.Clear();
			 	                          
		 	for(int i = 0; i < Coleccion.ListaDeArticulos.Count; i++)
			{
		 		if(Coleccion.ListaDeArticulos[i].tipoarticulo.Contains(TxtBuscarTipo.Text))
		 		{
		 			if(Coleccion.ListaDeArticulos[i].codigoarticulo.Contains(TxtBuscarCodigo.Text))
		 			{
		 				if(Coleccion.ListaDeArticulos[i].tituloarticulo.Contains(TxtBuscarArticulo.Text))
		 				{
		 					if(ChBDisponibilidad.Checked == true)
							{
		 						if(Coleccion.ListaDeArticulos[i].disponibilidadarticulo == true)
		 						{
		 							MostrarArticulos(i, Coleccion);
		 						}
		 					}
		 					if(ChBDisponibilidad.Checked == false)
							{
		 						if(Coleccion.ListaDeArticulos[i].disponibilidadarticulo == false)
		 						{
		 							MostrarArticulos(i, Coleccion);
		 						}
		 					}
		 				}
		 			}
		 		}
			}
		}
		
		private void CodigoCelda()
		{
			Colecciones Coleccion = new Colecciones();
			string CeldaSeleccionada;
			if(DataArticulos.Rows.Count != 0)
			{
				CeldaSeleccionada = DataArticulos.Rows[DataArticulos.CurrentRow.Index].Cells[0].Value.ToString();
			
				if(Modo_Inventario.Text == "Buscar Articulo")
				{
					for (int i = 0; i < Coleccion.ListaDeArticulos.Count; i++)
					{
						if (CeldaSeleccionada == Coleccion.ListaDeArticulos[i].codigoarticulo) {
							LlenarTextos(i);
						}
					}
				}
				if(Modo_Inventario.Text == "Vender Articulo")
				{
					for (int i = 0; i < Coleccion.ListaDeArticulos.Count; i++)
					{
						if (CeldaSeleccionada == Coleccion.ListaDeArticulos[i].codigoarticulo) {
							EnviarArticuloVenta(i, Coleccion);
						}
					}
				}
				if(Modo_Inventario.Text == "Recibir Articulo")
				{
					for (int i = 0; i < Coleccion.ListaDeArticulos.Count; i++)
					{
						if (CeldaSeleccionada == Coleccion.ListaDeArticulos[i].codigoarticulo) {
							EnviarArticuloCompra(i, Coleccion);
						}
					}
				}
			}
		}
		
		private void LlenarTextos(int i)
		{
			AgregarArticulo LlenarTexts = new AgregarArticulo();
			Colecciones Coleccion = new Colecciones();
			
			LlenarTexts.txtCodigo.Text = Coleccion.ListaDeArticulos[i].codigoarticulo.ToString();
			LlenarTexts.TxtArticulo.Text = Coleccion.ListaDeArticulos[i].tituloarticulo.ToString();
			LlenarTexts.TxtTitulo.Text = Coleccion.ListaDeArticulos[i].descripcionarticulo.ToString();
			LlenarTexts.TxtTipo.Text = Coleccion.ListaDeArticulos[i].tipoarticulo.ToString();
			LlenarTexts.TxtFechaF.Text = Coleccion.ListaDeArticulos[i].fabricacionarticulo.ToString();
			LlenarTexts.ChBoxDisponible.Checked = Coleccion.ListaDeArticulos[i].disponibilidadarticulo;
			LlenarTexts.LblAgregado.Text = Coleccion.ListaDeArticulos[i].fechaingresoarticulo.ToString();
			LlenarTexts.TxtPrecio.Text = Coleccion.ListaDeArticulos[i].precioarticulo.ToString("G", CultureInfo.CurrentCulture);
			LlenarTexts.LblAgregado.Visible = true;
			LlenarTexts.LblFijo.Visible = true;
			
			Dispose();
			LlenarTexts.ShowDialog();
		}
	
		private void MostrarArticulos(int i, Colecciones Coleccion)
		{
			int a = DataArticulos.Rows.Add();
			DataArticulos.Rows[a].Cells[0].Value = Coleccion.ListaDeArticulos[i].codigoarticulo;
			DataArticulos.Rows[a].Cells[1].Value = Coleccion.ListaDeArticulos[i].tituloarticulo;
			DataArticulos.Rows[a].Cells[2].Value = Coleccion.ListaDeArticulos[i].descripcionarticulo;
			DataArticulos.Rows[a].Cells[3].Value = Coleccion.ListaDeArticulos[i].tipoarticulo;
			DataArticulos.Rows[a].Cells[4].Value = Coleccion.ListaDeArticulos[i].fabricacionarticulo;
			DataArticulos.Rows[a].Cells[5].Value = Coleccion.ListaDeArticulos[i].precioarticulo.ToString("C2", CultureInfo.CurrentCulture);
			DataArticulos.Rows[a].Cells[6].Value = Coleccion.ListaDeArticulos[i].cantidadarticulo.ToString();
			DataArticulos.Rows[a].Cells[7].Value = Coleccion.ListaDeArticulos[i].diasprestamo.ToString();
		}
		
		private void EnviarArticuloVenta(int i, Colecciones Coleccion)
		{
			VenderProductos Vender = new VenderProductos();
			Vender.AgregarArticuloVenta(Coleccion.ListaDeArticulos[i]);
			Dispose();
			Vender.ShowDialog();
		}
		
		private void EnviarArticuloCompra(int i, Colecciones Coleccion)
		{
			RealizarDevolucion Recibir = new RealizarDevolucion();
			Recibir.ColocarArticulo(i, Coleccion);
			Dispose();
			Recibir.ShowDialog();
		}
		
		void BotonCerrarClick(object sender, EventArgs e)
		{
			if(Modo_Inventario.Text == "Buscar Articulo")
			{
				Dispose();
				AgregarArticulo Regresar = new AgregarArticulo();
				Regresar.ShowDialog();
			}
			if(Modo_Inventario.Text == "Vender Articulo")
			{
				Dispose();
				VenderProductos Regresar = new VenderProductos();
				Regresar.ShowDialog();
			}
			if(Modo_Inventario.Text == "Recibir Articulo")
			{
				Dispose();
				RealizarDevolucion Regresar = new RealizarDevolucion();
				Regresar.Show();
			}
			else
			{
				Dispose();
			}
		}
		
		void TxtBuscarArticuloKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				BuscarArticulos();
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtBuscarCodigoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				BuscarArticulos();
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtBuscarTipoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				BuscarArticulos();
				SendKeys.Send("{TAB}");
			}
		}
		
		void ChBDisponibilidadCheckedChanged(object sender, EventArgs e)
		{
			BuscarArticulos();
		}
		
		void DataArticulosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			CodigoCelda();
		}
		
	}
}
