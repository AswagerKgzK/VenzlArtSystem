using System;
using System.Collections.Generic;

namespace VenzlArtSystem
{
	public class Devolucion
	{
		private Articulos Productos;
		private int Cantidad;
		private DateTime Fecha;
		private string DevolucionCompra;
		private int CodigoCompra;
		
		public Articulos ProductosDoC {get{return Productos;}set{Productos = value;}}
		public int CantidadDoC {get{return Cantidad;}set{Cantidad = value;}}
		public DateTime FechaDoC {get{return Fecha;}set{Fecha = value;}}
		public string Devolucion_o_Compra {get{return DevolucionCompra;}set{DevolucionCompra = value;}}
		public int CodigoDoC {get{return CodigoCompra;}set{CodigoCompra = value;}}
		
		public Devolucion()
		{
			ProductosDoC = new Articulos();
			CantidadDoC = 1;
			FechaDoC = DateTime.Now;
			Devolucion_o_Compra = "";
			CodigoDoC = 0;
		}
		
		public Devolucion(Articulos a, int b, DateTime c, string d, int e) : this()
		{
			ProductosDoC = a;
			CantidadDoC = b;
			FechaDoC = c;
			Devolucion_o_Compra = d;
			CodigoDoC = e;
		}
		
		public override string ToString()
		{
			return string.Format("{0}, {1}, {2}, {3}, {4}", Productos, Cantidad, Fecha, DevolucionCompra, CodigoCompra);
		}

	}
}
