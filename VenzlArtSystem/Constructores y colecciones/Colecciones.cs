using System;
using System.Collections.Generic;
using System.IO;

namespace VenzlArtSystem
{
	public class Colecciones
	{
		private List<Articulos> ListaArticulos;
		public List<Articulos> ListaDeArticulos {get{return ListaArticulos;} set{ListaArticulos = value;}}
		
		private List<Clientes> ListaClientes;
		public List<Clientes> ListaDeClientes {get{return ListaClientes;} set{ListaClientes = value;}}
		
		private List<Ventas> ListaVentas;
		public List<Ventas> ListaDeVentas {get{return ListaVentas;} set{ListaVentas = value;}}
		
		private List<Devolucion> ListaDevolucion;
		public List<Devolucion> ListaDeDevolucion {get{return ListaDevolucion;} set{ListaDevolucion = value;}}
		
		public Colecciones()
		{
			ListaDeArticulos = new List<Articulos>();
			ListaDeClientes = new List<Clientes>();
			ListaDeVentas = new List<Ventas>();
			ListaDevolucion = new List<Devolucion>();
			
			try{CargarArticulos();} catch{GuardarArticulos();}
			
			try{CargarClientes();} catch{GuardarClientes();}
			
			try{CargarVentas();} catch{GuardarVentas();}
			
			try{CargarDevoluciones();} catch{GuardarDevoluciones();}
		}
		
		public void AgregarArticulo(string a, string b, string c, string d, float e, int f, string g, bool h, int i)
		{
			Articulos x = new Articulos(a,b,c,d,e,f,g,h,i);
			ListaDeArticulos.Add(x);
			GuardarArticulos();
			
			MensajeAviso Mostrar = new MensajeAviso();
			Mostrar.MensajeBox("Articulo agregado exitosamente.");
		}
		
		public void ModificarProducto(int i, string a, string b, string c, string d, float e, bool f, int g)
		{
			ListaDeArticulos[i].tituloarticulo = a;
			ListaDeArticulos[i].descripcionarticulo = b;
			ListaDeArticulos[i].tipoarticulo = c;
			ListaDeArticulos[i].fabricacionarticulo = d;
			ListaDeArticulos[i].precioarticulo = e;
			ListaDeArticulos[i].disponibilidadarticulo = f;
			ListaDeArticulos[i].diasprestamo = g;
			GuardarArticulos();
			
			MensajeAviso Mostrar = new MensajeAviso();
			Mostrar.MensajeBox("Articulo actualizado exitosamente.");
		}
		
		public void AgregarCliente(string a, string b, string c, string d, string e, string f, string g, string h)
		{
			Clientes x = new Clientes(a,b,c,d,e,f,g,h);
			ListaDeClientes.Add(x);
			GuardarClientes();
			
			MensajeAviso Mostrar = new MensajeAviso();
			Mostrar.MensajeBox("Cliente agregado exitosamente.");
		}
		
		public void ModificarCliente(int i, string a, string b, string c, string d, string e, string f, string g)
		{
			ListaDeClientes[i].Nombre = a;
			ListaDeClientes[i].Apellido = b;
			ListaDeClientes[i].CorreoElectronico = c;
			ListaDeClientes[i].Dirrecion = d;
			ListaDeClientes[i].Nacimiento = e;
			ListaDeClientes[i].TelefonoMovil = f;
			ListaDeClientes[i].TelefonoResidencial = g;
			GuardarClientes();
			
			MensajeAviso Mostrar = new MensajeAviso();
			Mostrar.MensajeBox("Cliente actualizado exitosamente.");
		}
		
		public void AgregarVenta(Clientes a, List<Articulos> b, List<DateTime> DT, List<int> c, List<float> d, float e, DateTime f, string g, int h)
		{
			Ventas x = new Ventas(a,b,DT,c,d,e,f,g,h);
			ListaDeVentas.Add(x);
			
			GuardarVentas();
			GuardarArticulos();
		}
		
		public void AgregarDevolucion(Articulos a, int b, DateTime c, string d, int e)
		{
			Devolucion x = new Devolucion(a,b,c,d,e);
			ListaDeDevolucion.Add(x);
			
			GuardarDevoluciones();
			GuardarArticulos();
		}
		
		private string DataArticulos = @"Articulos.txt";
		private string DataClientes = @"Clientes.txt";
		private string DataVentas = @"Ventas.txt";
		private string DataDevoluciones = @"Devoluciones.txt";
		private char Separador = '|';
		
		private void GuardarArticulos()
		{
			string Linea;
			FileStream Archivo = new FileStream(DataArticulos, FileMode.Create, FileAccess.Write);
			StreamWriter Escritura = new StreamWriter(Archivo);
			
			for(int i = 0; i < ListaArticulos.Count; i++)
			{
				Linea = LineaArticulo(ListaArticulos[i]);
				Escritura.WriteLine(Linea);
			}
			
			Escritura.Close();
		}
		
		private string LineaArticulo(Articulos Agregar)
		{
			string Separar = Separador.ToString().Trim();
			string Linea;
			
			Linea = Agregar.codigoarticulo + Separar;
			Linea += Agregar.tituloarticulo + Separar;
			Linea += Agregar.descripcionarticulo + Separar;
			Linea += Agregar.tipoarticulo + Separar;
			Linea += Agregar.precioarticulo.ToString("G") + Separar;
			Linea += Agregar.cantidadarticulo.ToString("G") + Separar;
			Linea += Agregar.fabricacionarticulo + Separar;
			Linea += Agregar.disponibilidadarticulo.ToString() + Separar;
			Linea += Agregar.diasprestamo.ToString() + Separar;
			Linea += Agregar.fechaingresoarticulo;
			
			return Linea;
		}
		
		private void CargarArticulos()
		{
			FileStream Archivo = new FileStream(DataArticulos, FileMode.Open, FileAccess.Read);
			StreamReader Lectura = new StreamReader(Archivo);
			
			ListaArticulos.Clear();
			string Linea = Lectura.ReadLine();
			string[] Objeto;
			while(Linea != null)
			{
				Objeto = Linea.Split(Separador);
				Articulos Recuperar = new Articulos();
				Recuperar.codigoarticulo = Objeto[0];
				Recuperar.tituloarticulo = Objeto[1];
				Recuperar.descripcionarticulo = Objeto[2];
				Recuperar.tipoarticulo = Objeto[3];
				Recuperar.precioarticulo = Convert.ToSingle(Objeto[4]);
				Recuperar.cantidadarticulo = Convert.ToInt32(Objeto[5]);
				Recuperar.fabricacionarticulo = Objeto[6];
				Recuperar.disponibilidadarticulo = Convert.ToBoolean(Objeto[7]);
				Recuperar.diasprestamo = Convert.ToInt32(Objeto[8]);
				Recuperar.fechaingresoarticulo = Objeto[9];
				ListaArticulos.Add(Recuperar);
				Linea = Lectura.ReadLine();
			}
			Lectura.Close();
		}
		
		private void GuardarClientes()
		{
			string Linea;
			FileStream Archivo = new FileStream(DataClientes, FileMode.Create, FileAccess.Write);
			StreamWriter Escritura = new StreamWriter(Archivo);
			
			for(int i = 0; i < ListaClientes.Count; i++)
			{
				Linea = LineaCliente(ListaClientes[i]);
				Escritura.WriteLine(Linea);
			}
			
			Escritura.Close();
		}
		
		private string LineaCliente(Clientes Agregar)
		{
			string Separar = Separador.ToString().Trim();
			string Linea;
			
			Linea = Agregar.Nombre + Separar;
			Linea += Agregar.Apellido + Separar;
			Linea += Agregar.Cedula + Separar;
			Linea += Agregar.Nacimiento + Separar;
			Linea += Agregar.Dirrecion + Separar;
			Linea += Agregar.CorreoElectronico + Separar;
			Linea += Agregar.TelefonoMovil + Separar;
			Linea += Agregar.TelefonoResidencial + Separar;
			Linea += Agregar.FechadeRegistro;
			
			return Linea;
		}
		
		private void CargarClientes()
		{
			FileStream Archivo = new FileStream(DataClientes, FileMode.Open, FileAccess.Read);
			StreamReader Lectura = new StreamReader(Archivo);
			
			ListaClientes.Clear();
			string Linea = Lectura.ReadLine();
			string[] Objeto;
			while(Linea != null)
			{
				Objeto = Linea.Split(Separador);
				Clientes Recuperar = new Clientes();
				Recuperar.Nombre = Objeto[0];
				Recuperar.Apellido = Objeto[1];
				Recuperar.Cedula = Objeto[2];
				Recuperar.Nacimiento = Objeto[3];
				Recuperar.Dirrecion = Objeto[4];
				Recuperar.CorreoElectronico = Objeto[5];
				Recuperar.TelefonoMovil = Objeto[6];
				Recuperar.TelefonoResidencial = Objeto[7];
				Recuperar.FechadeRegistro = Objeto[8];
				ListaClientes.Add(Recuperar);
				Linea = Lectura.ReadLine();
			}
			Lectura.Close();
		}
		
		private void GuardarVentas()
		{
			string Linea;
			FileStream Archivo = new FileStream(DataVentas, FileMode.Create, FileAccess.Write);
			StreamWriter Escritura = new StreamWriter(Archivo);
			
			for(int i = 0; i < ListaVentas.Count; i++)
			{
				Linea = LineaVentas(ListaVentas[i]);
				Escritura.WriteLine(Linea);
			}
			
			Escritura.Close();
		}
		
		private string LineaVentas(Ventas Agregar)
		{
			string Separar = Separador.ToString().Trim();
			string Linea;
			
			Linea = "1" + Separar + Agregar.Cliente.Nombre + Separar;
			Linea += Agregar.Cliente.Apellido + Separar;
			Linea += Agregar.Cliente.Cedula + Separar;
			Linea += Agregar.Cliente.Nacimiento + Separar;
			Linea += Agregar.Cliente.Dirrecion + Separar;
			Linea += Agregar.Cliente.CorreoElectronico + Separar;
			Linea += Agregar.Cliente.TelefonoMovil + Separar;
			Linea += Agregar.Cliente.TelefonoResidencial + Separar;
			Linea += Agregar.Cliente.FechadeRegistro + "\n";
			
			for(int i = 0; i < Agregar.ProductosVenta.Count; i++)
			{
				
				Linea += "2" + Separar + Agregar.ProductosVenta[i].codigoarticulo + Separar;
				Linea += Agregar.ProductosVenta[i].tituloarticulo + Separar;
				Linea += Agregar.ProductosVenta[i].descripcionarticulo + Separar;
				Linea += Agregar.ProductosVenta[i].tipoarticulo + Separar;
				Linea += Agregar.ProductosVenta[i].precioarticulo.ToString("G") + Separar;
				Linea += Agregar.ProductosVenta[i].cantidadarticulo.ToString("G") + Separar;
				Linea += Agregar.ProductosVenta[i].fabricacionarticulo + Separar;
				Linea += Agregar.ProductosVenta[i].disponibilidadarticulo.ToString() + Separar;
				Linea += Agregar.ProductosVenta[i].diasprestamo.ToString() + Separar;
				Linea += Agregar.ProductosVenta[i].fechaingresoarticulo + "\n";
			
			}
			
			Linea += "3";
			
			for(int i = 0; i < Agregar.DevolucionProductos.Count; i++)
			{
				Linea += Separar + Agregar.DevolucionProductos[i].ToString("s");
			}
			
			Linea += "\n4";
			
			for(int i = 0; i < Agregar.CantidadProductos.Count; i++)
			{
				Linea += Separar + Agregar.CantidadProductos[i].ToString();
			}
			
			Linea += "\n5";
			
			for(int i = 0; i < Agregar.PreciosProductos.Count; i++)
			{
				Linea += Separar + Agregar.PreciosProductos[i].ToString("G");
			}
			
			Linea += "\n6" + Separar + Agregar.PrecioTotal.ToString("G");
			Linea += "\n7" + Separar + Agregar.Realizado.ToString("s");
			Linea += "\n8" + Separar + Agregar.Pagado;
			Linea += "\n9" + Separar + Agregar.CodigoVentaProductos.ToString();
			
			return Linea;
		}
		
		private void CargarVentas()
		{
			FileStream Archivo = new FileStream(DataVentas, FileMode.Open, FileAccess.Read);
			StreamReader Lectura = new StreamReader(Archivo);
			
			ListaVentas.Clear();
			string Linea = Lectura.ReadLine();
			string[] Objeto;
			
			while(Linea != null)
			{
				List<Articulos> AñadirArticuloCargar = new List<Articulos>();
				List<DateTime> AñadirTiempoCargar = new List<DateTime>();
				List<int> AñadirCantidadCargar = new List<int>();
				List<float> AñadirPrecioCargar = new List<float>();
				float CargarTotal;
				DateTime CargarTiempoVenta;
				string MetodoPagado;
				int Documento;
			
				Objeto = Linea.Split(Separador);
				
				Clientes Recuperar = new Clientes();
					
				Recuperar.Nombre = Objeto[1];
				Recuperar.Apellido = Objeto[2];
				Recuperar.Cedula = Objeto[3];
				Recuperar.Nacimiento = Objeto[4];
				Recuperar.Dirrecion = Objeto[5];
				Recuperar.CorreoElectronico = Objeto[6];
				Recuperar.TelefonoMovil = Objeto[7];
				Recuperar.TelefonoResidencial = Objeto[8];
				Recuperar.FechadeRegistro = Objeto[9];
					
				Linea = Lectura.ReadLine();
				Objeto = Linea.Split(Separador);
				
				while(Objeto[0] == "2")
				{
					Articulos RecuperarArchivo = new Articulos();
					
					RecuperarArchivo.codigoarticulo = Objeto[1];
					RecuperarArchivo.tituloarticulo = Objeto[2];
					RecuperarArchivo.descripcionarticulo = Objeto[3];
					RecuperarArchivo.tipoarticulo = Objeto[4];
					RecuperarArchivo.precioarticulo = Convert.ToSingle(Objeto[5]);
					RecuperarArchivo.cantidadarticulo = Convert.ToInt32(Objeto[6]);
					RecuperarArchivo.fabricacionarticulo = Objeto[7];
					RecuperarArchivo.disponibilidadarticulo = Convert.ToBoolean(Objeto[8]);
					RecuperarArchivo.diasprestamo = Convert.ToInt32(Objeto[9]);
					RecuperarArchivo.fechaingresoarticulo = Objeto[10];
					
					AñadirArticuloCargar.Add(RecuperarArchivo);
					
					Linea = Lectura.ReadLine();
					Objeto = Linea.Split(Separador);
				}
				
				while(Objeto[0] == "3")
				{
					for(int i = 1; i < Objeto.Length; i++)
					{
						AñadirTiempoCargar.Add(Convert.ToDateTime(Objeto[i]));
					}
					
					Linea = Lectura.ReadLine();
					Objeto = Linea.Split(Separador);
				}
				
				while(Objeto[0] == "4")
				{
					for(int i = 1; i < Objeto.Length; i++)
					{
						AñadirCantidadCargar.Add(Convert.ToInt32(Objeto[i]));
					}
					
					Linea = Lectura.ReadLine();
					Objeto = Linea.Split(Separador);
				}
				
				while(Objeto[0] == "5")
				{
					for(int i = 1; i < Objeto.Length; i++)
					{
						AñadirPrecioCargar.Add(Convert.ToSingle(Objeto[i]));
					}
					
					Linea = Lectura.ReadLine();
					Objeto = Linea.Split(Separador);
				}
				
				CargarTotal = Convert.ToSingle(Objeto[1]);
				
				Linea = Lectura.ReadLine();
				Objeto = Linea.Split(Separador);
					
				CargarTiempoVenta = Convert.ToDateTime(Objeto[1]);
				
				Linea = Lectura.ReadLine();
				Objeto = Linea.Split(Separador);
				
				MetodoPagado = Objeto[1];
								
				Linea = Lectura.ReadLine();
				Objeto = Linea.Split(Separador);
				
				Documento = Convert.ToInt32(Objeto[1]);
				
				Ventas x = new Ventas(Recuperar, AñadirArticuloCargar, AñadirTiempoCargar, AñadirCantidadCargar, AñadirPrecioCargar, CargarTotal, CargarTiempoVenta, MetodoPagado, Documento);
				ListaVentas.Add(x);
				
				Linea = Lectura.ReadLine();
			}
			
			Lectura.Close();
		}
		
		private void GuardarDevoluciones()
		{
			string Linea;
			FileStream Archivo = new FileStream(DataDevoluciones, FileMode.Create, FileAccess.Write);
			StreamWriter Escritura = new StreamWriter(Archivo);
			
			for(int i = 0; i < ListaDevolucion.Count; i++)
			{
				Linea = LineaDevolucion(ListaDevolucion[i]);
				Escritura.WriteLine(Linea);
			}
			
			Escritura.Close();
		}
		
		private string LineaDevolucion(Devolucion Agregar)
		{
			string Separar = Separador.ToString().Trim();
			string Linea;
			
			Linea = Agregar.ProductosDoC.codigoarticulo + Separar;
			Linea += Agregar.ProductosDoC.tituloarticulo + Separar;
			Linea += Agregar.ProductosDoC.descripcionarticulo + Separar;
			Linea += Agregar.ProductosDoC.tipoarticulo + Separar;
			Linea += Agregar.ProductosDoC.precioarticulo.ToString("G") + Separar;
			Linea += Agregar.ProductosDoC.cantidadarticulo.ToString("G") + Separar;
			Linea += Agregar.ProductosDoC.fabricacionarticulo + Separar;
			Linea += Agregar.ProductosDoC.disponibilidadarticulo.ToString() + Separar;
			Linea += Agregar.ProductosDoC.diasprestamo.ToString() + Separar;
			Linea += Agregar.ProductosDoC.fechaingresoarticulo + Separar;
			
			Linea += Agregar.CantidadDoC.ToString() + Separar;
			Linea += Agregar.FechaDoC.ToString("s") + Separar;
			Linea += Agregar.Devolucion_o_Compra + Separar;
			Linea += Agregar.CodigoDoC.ToString();
			
			return Linea;
		}
		
		private void CargarDevoluciones()
		{
			FileStream Archivo = new FileStream(DataDevoluciones, FileMode.Open, FileAccess.Read);
			StreamReader Lectura = new StreamReader(Archivo);
			
			ListaDevolucion.Clear();
			string Linea = Lectura.ReadLine();
			string[] Objeto;
			
			int CantidadC, CodigoC;
			DateTime FechaC;
			string ModoC;
			
			while(Linea != null)
			{
				Objeto = Linea.Split(Separador);
				Articulos Recuperar = new Articulos();
				Recuperar.codigoarticulo = Objeto[0];
				Recuperar.tituloarticulo = Objeto[1];
				Recuperar.descripcionarticulo = Objeto[2];
				Recuperar.tipoarticulo = Objeto[3];
				Recuperar.precioarticulo = Convert.ToSingle(Objeto[4]);
				Recuperar.cantidadarticulo = Convert.ToInt32(Objeto[5]);
				Recuperar.fabricacionarticulo = Objeto[6];
				Recuperar.disponibilidadarticulo = Convert.ToBoolean(Objeto[7]);
				Recuperar.diasprestamo = Convert.ToInt32(Objeto[8]);
				Recuperar.fechaingresoarticulo = Objeto[9];
				
				CantidadC = Convert.ToInt32(Objeto[10]);
				FechaC = Convert.ToDateTime(Objeto[11]);
				ModoC = Objeto[12];
				CodigoC = Convert.ToInt32(Objeto[13]);
				
				Devolucion x = new Devolucion(Recuperar, CantidadC, FechaC, ModoC, CodigoC);
				ListaDevolucion.Add(x);
				Linea = Lectura.ReadLine();
			}
			Lectura.Close();
		}
	}
}
