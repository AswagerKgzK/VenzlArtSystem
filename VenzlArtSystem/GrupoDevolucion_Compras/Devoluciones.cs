using System;
using System.Drawing;
using System.Windows.Forms;

namespace VenzlArtSystem
{
	public partial class Devoluciones : Form
	{
		public Devoluciones()
		{
			InitializeComponent();
			LlenarTodo();
		}
		
		private void LlenarTodo()
		{
			Colecciones Buscar = new Colecciones();
			DatosDevolucionCompra.Rows.Clear();
			for(int i = 0; i < Buscar.ListaDeDevolucion.Count; i++)
			{
				LlenarDataGrid(i, Buscar);
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
			DatosDevolucionCompra.Rows.Clear();
			for(int i = 0; i < Buscar.ListaDeDevolucion.Count; i++)
			{
				if(FechaBusqueda.ToShortDateString() == Buscar.ListaDeDevolucion[i].FechaDoC.ToShortDateString())
				{
					LlenarDataGrid(i, Buscar);
				}
			}
			TxtFecha.Text = "";
		}
		
		private void LlenarDataGrid(int i, Colecciones Coleccion)
		{
			int a = DatosDevolucionCompra.Rows.Add();
			DatosDevolucionCompra.Rows[a].Cells[0].Value = Coleccion.ListaDeDevolucion[i].CodigoDoC.ToString();
			DatosDevolucionCompra.Rows[a].Cells[1].Value = Coleccion.ListaDeDevolucion[i].Devolucion_o_Compra;
			DatosDevolucionCompra.Rows[a].Cells[2].Value = Coleccion.ListaDeDevolucion[i].ProductosDoC.tituloarticulo;
			DatosDevolucionCompra.Rows[a].Cells[3].Value = Coleccion.ListaDeDevolucion[i].ProductosDoC.tipoarticulo;
			DatosDevolucionCompra.Rows[a].Cells[4].Value = Coleccion.ListaDeDevolucion[i].CantidadDoC.ToString();
			DatosDevolucionCompra.Rows[a].Cells[5].Value = Coleccion.ListaDeDevolucion[i].FechaDoC.ToShortDateString();
		}
		
		void BotonMostrarFechaClick(object sender, EventArgs e)
		{
			MostrarFecha();
		}
		
		void BotonCerrarClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void BotonMostrarTodoClick(object sender, EventArgs e)
		{
			LlenarTodo();
		}
		
		void TxtFechaKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				MostrarFecha();
				SendKeys.Send("{TAB}");
			}
		}
	}
}
