using System;
using System.Drawing;
using System.Windows.Forms;

namespace VenzlArtSystem
{
	public partial class AgregarCliente : Form
	{
		public AgregarCliente()
		{
			InitializeComponent();
		}
		
		private void Agregar_Modificar()
		{
			if(Validar() == true)
			{
				Colecciones Buscar = new Colecciones();
				for (int i = 0; i < Buscar.ListaDeClientes.Count; i++)
				{
					if(txtCedula.Text == Buscar.ListaDeClientes[i].Cedula)
					{
						MensajeAviso Mensaje = new MensajeAviso();
						Mensaje.MensajeBox("¿Este código ya existe, desea actualizarlo?", "¡Atencion!", "Si", "No");
						if(Mensaje.MensajeResultado == "Si")
						{
							Buscar.ModificarCliente(i, TxtNombre.Text.Trim(), TxtApellido.Text.Trim(), TxtCorreo.Text.Trim(), txtDireccion.Text.Trim(), TxtNacimiento.Text, TxtTelefonoP.Text, txtTelefonoR.Text);
							LimpiarTextos();
						}
						return;
					}
				}
				Buscar.AgregarCliente(txtCedula.Text, TxtNombre.Text.Trim(), TxtApellido.Text.Trim(), TxtCorreo.Text.Trim(), txtDireccion.Text.Trim(), TxtNacimiento.Text, TxtTelefonoP.Text, txtTelefonoR.Text);
				LimpiarTextos();
				return;
			}
		}
		
		private void Rellenar()
		{
			Colecciones Coleccion = new Colecciones();
			
			for (int i = 0; i < Coleccion.ListaDeClientes.Count; i++)
			{
				if(Coleccion.ListaDeClientes[i].Cedula == txtCedula.Text)
				{
					TxtNombre.Text = Coleccion.ListaDeClientes[i].Nombre;
					TxtApellido.Text = Coleccion.ListaDeClientes[i].Apellido;
					TxtCorreo.Text = Coleccion.ListaDeClientes[i].CorreoElectronico;
					txtDireccion.Text = Coleccion.ListaDeClientes[i].Dirrecion;
					TxtNacimiento.Text = Coleccion.ListaDeClientes[i].Nacimiento;
					TxtTelefonoP.Text = Coleccion.ListaDeClientes[i].TelefonoMovil;
					txtTelefonoR.Text = Coleccion.ListaDeClientes[i].TelefonoResidencial;
					LblAgregado.Text = Coleccion.ListaDeClientes[i].FechadeRegistro;
					LblFijo.Visible = true;
					LblAgregado.Visible = true;
					return;
				}
			}
			return;
		}
		
		private void LimpiarTextos()
		{
			txtCedula.Text = "";
			TxtNombre.Text = "";
			TxtApellido.Text = "";
			TxtCorreo.Text = "";
			txtDireccion.Text = "";
			TxtNacimiento.Text = "";
			TxtTelefonoP.Text = "";
			txtTelefonoR.Text = "";
			LblFijo.Visible = false;
			LblAgregado.Visible = false;
			ReiniciarColores();
		}
		
		private void ReiniciarColores()
		{
			txtCedula.BackColor = Color.White;
			TxtApellido.BackColor = Color.White;
			TxtCorreo.BackColor = Color.White;
			txtDireccion.BackColor = Color.White;
			TxtNacimiento.BackColor = Color.White;
			TxtNombre.BackColor = Color.White;
			TxtTelefonoP.BackColor = Color.White;
			txtTelefonoR.BackColor = Color.White;
		}
		
		private void MostrarErrores(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h)
		{
			ReiniciarColores();
			if(!a) txtCedula.BackColor = Color.Pink;
			if(!b) TxtNombre.BackColor = Color.Pink;
			if(!c) TxtApellido.BackColor = Color.Pink;
			if(!d) TxtCorreo.BackColor = Color.Pink;
			if(!e) txtDireccion.BackColor = Color.Pink;
			if(!f) TxtNacimiento.BackColor = Color.Pink;
			if(!g) TxtTelefonoP.BackColor = Color.Pink;
			if(!h) txtTelefonoR.BackColor = Color.Pink;
		}
		
		private bool Validar()
		{
			bool v1, v2, v3, v4, v5, v6, v7, v8;
			
			ValidarTextos Validar = new ValidarTextos();
			
			v1 = Validar.ValidacionCedula(txtCedula.Text);
			v2 = Validar.ValidacionVacio(TxtNombre.Text);
			v3 = Validar.ValidacionVacio(TxtApellido.Text);
			v4 = Validar.ValidacionEmail(TxtCorreo.Text);
			v5 = Validar.ValidacionVacio(txtDireccion.Text);
			v6 = Validar.ValidacionFechas(TxtNacimiento.Text);
			v7 = Validar.ValidacionTelefonica(TxtTelefonoP.Text);
			v8 = Validar.ValidacionTelefonica(txtTelefonoR.Text);
			
			if(v1 && v2 && v3 && v4 && v5 && v6 && v7 && v8)
			{
				return true;
			}
			else
			{
				MostrarErrores(v1, v2, v3, v4, v5, v6, v7, v8);
			}
			
			MensajeAviso mensaje = new MensajeAviso();
			mensaje.MensajeBox("Por favor ingrese datos validos.", "Aviso");
			return false;
		}
		
		void BotonReiniciarClick(object sender, EventArgs e)
		{
			LimpiarTextos();
		}
		
		void BotonCerrarClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void BotonBuscarClick(object sender, EventArgs e)
		{
			Dispose();
			AgendaClientes BuscarCliente = new AgendaClientes();
			BuscarCliente.Modo_Cliente.Text = "Buscar Cliente";
			BuscarCliente.Show();
		}
		
		void TxtCedulaKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				Rellenar();
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtApellidoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtCorreoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtDireccionKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtNacimientoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtTelefonoPKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtTelefonoRKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		
		void BotonAgregar_ActualizarClick(object sender, EventArgs e)
		{
			Agregar_Modificar();
		}
	}
}
