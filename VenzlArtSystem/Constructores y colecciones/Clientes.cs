using System;

namespace VenzlArtSystem
{
	public class Clientes
	{
		private string nombre, apellido, cedula, nacimiento, direccion, correoelectronico, numerotelefonico, numeroresidencia, registrado;
		
		public string Nombre {get{return nombre;}set{nombre = value;}}
		public string Apellido {get{return apellido;}set{apellido = value;}}
		public string Cedula {get{return cedula;}set{cedula = value;}}
		public string Nacimiento {get{return nacimiento;}set{nacimiento = value;}}
		public string Dirrecion {get{return direccion;}set{direccion = value;}}
		public string CorreoElectronico {get{return correoelectronico;}set{correoelectronico = value;}}
		public string TelefonoMovil {get{return numerotelefonico;}set{numerotelefonico = value;}}
		public string TelefonoResidencial {get{return numeroresidencia;}set{numeroresidencia= value;}}
		public string FechadeRegistro {get{return registrado;}set{registrado = value;}}
		
		public Clientes()
		{
			Nombre = "Desconocido";
			Apellido = "Desconocido";
			Cedula = "00000000";
			Nacimiento = "01/01/1999";
			Dirrecion = "Ninguno";
			CorreoElectronico = "anonimo@gmail.com";
			TelefonoMovil = "0000-0000000";
			TelefonoResidencial = "0000-0000000";
			FechadeRegistro = DateTime.Now.ToShortDateString();
		}
		
		public Clientes(string a, string b, string c, string d, string e, string f, string g, string h) : this()
		{
			Cedula = a;
			Nombre = b;
			Apellido = c;
			CorreoElectronico = d;
			Dirrecion = e;
			Nacimiento = f;
			TelefonoMovil = g;
			TelefonoResidencial = h;
		}
		
		public override string ToString()
		{
			return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", nombre, apellido, cedula, nacimiento, direccion, correoelectronico, numerotelefonico, numeroresidencia, registrado);
		}

	}
}
