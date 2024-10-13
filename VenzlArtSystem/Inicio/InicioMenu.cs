using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace VenzlArtSystem
{
	public partial class InicioMenu : Form
	{
		private int OpcionMain;
		private int OpcionSecond;
		
		public InicioMenu()
		{
			InitializeComponent();
		}
		
		private void SonarMusica(string cancion)
		{
			SoundPlayer Musica = new SoundPlayer(@"Canciones\" + cancion + ".wav");
			try
			{
				Musica.PlayLooping();
			}
			catch{}
		}
		
		private void DetenerMusica()
		{
			SoundPlayer Musica = new SoundPlayer();
			try
			{
				Musica.Stop();
			}
			catch{}
		}
		
		private void DirigirFormulario()
		{
			if(OpcionMain == 1 && OpcionSecond == 1)
			{
				AgregarArticulo Agregar = new AgregarArticulo();
				Agregar.ShowDialog();
			}
			if(OpcionMain == 1 && OpcionSecond == 2)
			{
				Inventario Observar = new Inventario();
				Observar.Modo_Inventario.Text = "Inventario";
				Observar.ShowDialog();
			}
			if(OpcionMain == 2 && OpcionSecond == 1)
			{
				AgregarCliente AgregarCliente = new AgregarCliente();
				AgregarCliente.ShowDialog();
			}
			if(OpcionMain == 2 && OpcionSecond == 2)
			{
				AgendaClientes VerClientes = new AgendaClientes();
				VerClientes.Modo_Cliente.Text = "Clientes";
				VerClientes.ShowDialog();
			}
			if(OpcionMain == 3 && OpcionSecond == 1)
			{
				RealizarDevolucion RecibirProductos = new RealizarDevolucion();
				RecibirProductos.ShowDialog();
			}
			if(OpcionMain == 3 && OpcionSecond == 2)
			{
				Devoluciones VerDevoluciones = new Devoluciones();
				VerDevoluciones.ShowDialog();
			}
			if(OpcionMain == 4 && OpcionSecond == 1)
			{
				VenderProductos Vender = new VenderProductos();
				Vender.ShowDialog();
			}
			if(OpcionMain == 4 && OpcionSecond == 2)
			{
				VentasRealizadas VerVentas = new VentasRealizadas();
				VerVentas.ShowDialog();
			}
		}
		
		void ImgSonarClick(object sender, EventArgs e)
		{
			SonarMusica(ControlMusica.Text);
		}
		
		void ImgPararClick(object sender, EventArgs e)
		{
			DetenerMusica();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			OpcionMain = 1;
			PanelMostrarOpciones.Visible = true;
			LabelAñadir.Text = "Añadir Articulo";
			LabelVer.Text = "Ver Inventario";
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			OpcionMain = 2;
			PanelMostrarOpciones.Visible = true;
			LabelAñadir.Text = "Añadir Cliente";
			LabelVer.Text = "Ver Clientes";
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			OpcionMain = 3;
			PanelMostrarOpciones.Visible = true;
			LabelAñadir.Text = "Realizar Compra o Devolucion";
			LabelVer.Text = "Ver Compras o Devoluciones";
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			OpcionMain = 4;
			PanelMostrarOpciones.Visible = true;
			LabelAñadir.Text = "Realizar Venta o Prestamo";
			LabelVer.Text = "Ver Ventas o Prestamos";
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			OpcionSecond = 1;
			PanelMostrarOpciones.Visible = false;
			DirigirFormulario();
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			OpcionSecond = 2;
			PanelMostrarOpciones.Visible = false;
			DirigirFormulario();
		}
		
		void PictureBox7Click(object sender, EventArgs e)
		{
			MensajeAviso Mensaje = new MensajeAviso();
			Mensaje.MensajeBox("¿Seguro deseas salir?", "¡Alerta!", "Si.", "No.");
			if (Mensaje.MensajeResultado == "Si.")
			{
				Application.Exit();
			}
		}
		
		void PictureBox8Click(object sender, EventArgs e)
		{
			Ayuda x = new Ayuda();
			x.ShowDialog();
		}
	
		void ControlMusicaSelectedItemChanged(object sender, EventArgs e)
		{
			SonarMusica(ControlMusica.Text);
		}
		
	}
}
