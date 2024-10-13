using System;
using System.Collections.Generic;

namespace VenzlArtSystem
{
	public class Ventas
	{
		private Clientes Persona;
		private List<Articulos> Productos;
		private List<DateTime> Devolucion;
		private List<int> Cantidades;
		private List<float> Precios;
		private float TotalPrecios;
		private DateTime VentaRealizada;
		private string FormaDePago;
		private int CodigoVenta;
		
		public Clientes Cliente {get{return Persona;} set{Persona = value;}}
		public List<Articulos> ProductosVenta {get{return Productos;} set{Productos = value;}}
		public List<DateTime> DevolucionProductos {get{return Devolucion;} set{Devolucion = value;}}
		public List<int> CantidadProductos {get{return Cantidades;} set{Cantidades = value;}}
		public List<float> PreciosProductos {get{return Precios;} set{Precios = value;}}
		public float PrecioTotal {get{return TotalPrecios;} set{TotalPrecios = value;}}
		public DateTime Realizado {get{return VentaRealizada;} set{VentaRealizada = value;}}
		public string Pagado {get{return FormaDePago;} set{FormaDePago = value;}}
		public int CodigoVentaProductos {get{return CodigoVenta;} set{CodigoVenta = value;}}
		
		public Ventas()
		{
			Cliente = new Clientes();
			ProductosVenta = new List<Articulos>();
			DevolucionProductos = new List<DateTime>();
			CantidadProductos = new List<int>();
			PreciosProductos = new List<float>();
			PrecioTotal = 0.0f;
			Realizado = DateTime.Now;
			Pagado = "";
		}
		
		public Ventas(Clientes a, List<Articulos> b, List<DateTime> DT, List<int> c, List<float> d, float e, DateTime f, string g, int h) : this()
		{
			Cliente = a;
			ProductosVenta = b;
			DevolucionProductos = DT;
			CantidadProductos = c;
			PreciosProductos = d;
			PrecioTotal = e;
			Realizado = f;
			Pagado = g;
			CodigoVentaProductos = h;
		}
		
		public override string ToString()
		{
			string ProductoTotal = string.Join("\n", Productos);
			string DevolucionesTotales = string.Join("\n", Devolucion);
			string CantidadesTotales = string.Join("\n", Cantidades);
			string PreciosTotales = string.Join("\n", Precios);
			return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", Persona, ProductoTotal, DevolucionesTotales, CantidadesTotales, PreciosTotales, TotalPrecios, VentaRealizada, FormaDePago, CodigoVenta);
		}


	}
}
