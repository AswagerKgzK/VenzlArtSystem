using System;

namespace VenzlArtSystem
{
	public class ValidarTextos
	{
		public bool ValidacionNumerica(string texto)
		{
			if(texto.Contains("."))
			{
				return false;
			}
			try
			{
				float Numero;
				Numero = Convert.ToSingle(texto);
				if(Numero <= 0)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		
		public bool ValidacionNumerosEnteros(string texto)
		{
			try
			{
				float Numero;
				Numero = Convert.ToInt32(texto);
				if(Numero < 0)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		
		public bool ValidacionEmail(string texto)
		{
			bool validacion = false;
			string[] caracteres = new string[] {"á", "é", "í", "ó", "ú", " ", "(", ")", "/", "%", "\'",
				"$", "=", ",", ";", ":", "<", ">", "\"", "\\", "[", "]", "{", "}", "&", "¿", "?", "¡", "!"};
			
			if (texto == "") 
			{
				return false;
			}
			
			for (int i = 0; i < caracteres.Length; i++)
			{
				validacion = texto.Contains(caracteres[i]);
				if (validacion)
				{
					return false;
				}
			}
			return true;
		}
		
		public bool ValidacionFechas(string texto)
		{
			try
			{
				DateTime Fecha;
				Fecha = Convert.ToDateTime(texto);
				if(Fecha > DateTime.Now)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		
		public bool ValidacionCodigo(string texto)
		{
			try
			{
				long Codigo;
				Codigo = Convert.ToInt64(texto);
				if(Codigo < 0)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		
		public bool ValidacionVacio(string texto)
		{
			string Espacios;
			Espacios = texto.Trim();
			if(Espacios == "")
			{
				return false;
			}
			return true;
		}
		
		public bool ValidacionCedula(string texto)
		{
			try
			{
				int Verificacion;
				Verificacion = Convert.ToInt32(texto);
				if(Verificacion <= 0)
				{
					return false;
				}
				if(texto.Length < 6 || texto.Length > 8)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		
		public bool ValidacionTelefonica(string texto)
		{
			try
			{
				long Telefono;
				Telefono = Convert.ToInt64(texto);
				if(Telefono < 0)
				{
					return false;
				}
				if(texto.Length < 11)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
	
	}
}