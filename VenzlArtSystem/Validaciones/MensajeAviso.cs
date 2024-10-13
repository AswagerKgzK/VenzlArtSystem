using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VenzlArtSystem
{
	public partial class MensajeAviso : Form
	{
		public string MensajeResultado;
		
		public MensajeAviso()
		{
			InitializeComponent();
		}
		
		public void MensajeBox(string a)
		{
			LblMensaje.Text = a;
			Boton2.Text = "OK";
			ShowDialog();
		}
		
		public void MensajeBox(string a, string b)
		{
			LblMensaje.Text = a;
			LblAviso.Text = b;
			Boton2.Text = "OK";
			ShowDialog();
		}
		
		public void MensajeBox(string a, string b, string c)
		{
			LblMensaje.Text = a;
			LblAviso.Text = b;
			Boton2.Text = c;
			ShowDialog();
		}
		
		public void MensajeBox(string a, string b, string c, string d)
		{
			LblMensaje.Text = a;
			LblAviso.Text = b;
			Boton2.Text = c;
			Boton3.Text = d;
			Boton3.Visible = true;
			ShowDialog();
		}
		
		public void MensajeBox(string a, string b, string c, string d, string e)
		{
			LblMensaje.Text = a;
			LblAviso.Text = b;
			Boton1.Text = c;
			Boton2.Text = d;
			Boton3.Text = e;
			Boton1.Visible = true;
			Boton3.Visible = true;
			ShowDialog();
		}
		
		void Boton3Click(object sender, EventArgs e)
		{
			MensajeResultado = Boton3.Text;
			Dispose();
		}
		
		void Boton2Click(object sender, EventArgs e)
		{
			MensajeResultado = Boton2.Text;
			Dispose();
		}
		
		void Boton1Click(object sender, EventArgs e)
		{
			MensajeResultado = Boton1.Text;
			Dispose();
		}
		
		void BotonCerrarClick(object sender, EventArgs e)
		{
			MensajeResultado = "Close";
			Dispose();
		}
	}
}
