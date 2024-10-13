using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace VenzlArtSystem
{
	public partial class AgendaClientes : Form
	{
		public AgendaClientes()
		{
			InitializeComponent();
			BuscarClientes();
		}
		
		private void BuscarClientes()
		{
			DataClientes.Rows.Clear();
			Colecciones Coleccion = new Colecciones();
			
		 	for(int i = Coleccion.ListaDeClientes.Count; i > 0; i--)
			{
		 		if(Coleccion.ListaDeClientes[i-1].Nombre.Contains(TxtBuscarNombre.Text))
		 		{
		 			if(Coleccion.ListaDeClientes[i-1].Cedula.Contains(TxtBuscarCedula.Text))
		 			{
		 				MostrarClientes(i-1, Coleccion);
		 			}
		 		}
			}
		}
		
		private void EditarCliente()
		{
			string CeldaSeleccionada;
			Colecciones Coleccion = new Colecciones();
			
			if(DataClientes.Rows.Count != 0)
			{
				CeldaSeleccionada = DataClientes.Rows[DataClientes.CurrentRow.Index].Cells[0].Value.ToString();
			
				if(Modo_Cliente.Text == "Buscar Cliente")
				{
					for (int i = 0; i < Coleccion.ListaDeClientes.Count; i++)
					{
						if (CeldaSeleccionada == Coleccion.ListaDeClientes[i].Cedula) {
							LlenarCliente(i);
						}
					}
				}
				if(Modo_Cliente.Text == "Venta al Cliente")
				{
					for (int i = 0; i < Coleccion.ListaDeClientes.Count; i++)
					{
						if (CeldaSeleccionada == Coleccion.ListaDeClientes[i].Cedula) {
							VenderProductos Regresar = new VenderProductos();
							Regresar.AgregarClienteVenta(Coleccion.ListaDeClientes[i]);
							Dispose();
							Regresar.ShowDialog();
						}
					}
				}
			}
		}
		
		private void LlenarCliente(int i)
		{
			AgregarCliente LlenarCliente = new AgregarCliente();
			Colecciones Coleccion = new Colecciones();
			
			LlenarCliente.txtCedula.Text = Coleccion.ListaDeClientes[i].Cedula.ToString();
			LlenarCliente.TxtNombre.Text = Coleccion.ListaDeClientes[i].Nombre.ToString();
			LlenarCliente.TxtApellido.Text = Coleccion.ListaDeClientes[i].Apellido.ToString();
			LlenarCliente.TxtCorreo.Text = Coleccion.ListaDeClientes[i].CorreoElectronico.ToString();
			LlenarCliente.txtDireccion.Text = Coleccion.ListaDeClientes[i].Dirrecion.ToString();
			LlenarCliente.TxtNacimiento.Text = Coleccion.ListaDeClientes[i].Nacimiento.ToString();
			LlenarCliente.LblAgregado.Text = Coleccion.ListaDeClientes[i].FechadeRegistro.ToString();
			LlenarCliente.TxtTelefonoP.Text = Coleccion.ListaDeClientes[i].TelefonoMovil.ToString();
			LlenarCliente.txtTelefonoR.Text = Coleccion.ListaDeClientes[i].TelefonoResidencial.ToString();
			LlenarCliente.LblAgregado.Visible = true;
			LlenarCliente.LblFijo.Visible = true;
			
			Dispose();
			LlenarCliente.ShowDialog();
		}
		
		private void MostrarClientes(int i, Colecciones Coleccion)
		{
			int a = DataClientes.Rows.Add();
			DataClientes.Rows[a].Cells[0].Value = Coleccion.ListaDeClientes[i].Cedula;
			DataClientes.Rows[a].Cells[1].Value = Coleccion.ListaDeClientes[i].Nombre + " " + Coleccion.ListaDeClientes[i].Apellido;
			DataClientes.Rows[a].Cells[2].Value = Coleccion.ListaDeClientes[i].CorreoElectronico;
			DataClientes.Rows[a].Cells[3].Value = Coleccion.ListaDeClientes[i].Dirrecion;
			DataClientes.Rows[a].Cells[4].Value = Coleccion.ListaDeClientes[i].Nacimiento;
			DataClientes.Rows[a].Cells[5].Value = Coleccion.ListaDeClientes[i].TelefonoMovil + " & " + Coleccion.ListaDeClientes[i].TelefonoResidencial;
		}
		
		void BotonCerrarClick(object sender, EventArgs e)
		{
			if(Modo_Cliente.Text == "Buscar Articulo")
			{
				Dispose();
				AgregarCliente Regresar = new AgregarCliente();
				Regresar.ShowDialog();
			}
			if(Modo_Cliente.Text == "Venta al Cliente")
			{
				Dispose();
				VenderProductos Regresar = new VenderProductos();
				Regresar.ShowDialog();
			}
			else
			{
				Dispose();
			}
		}
		
		void TxtBuscarNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				BuscarClientes();
				SendKeys.Send("{TAB}");
			}
		}
		
		void TxtBuscarCedulaKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == (int)Keys.Enter)
			{
				BuscarClientes();
				SendKeys.Send("{TAB}");
			}
		}
		
		void DataClientesCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			EditarCliente();
		}
	}
}
