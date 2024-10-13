using System;

namespace VenzlArtSystem
{
	public class Articulos
	{		
		private string TituloArticulo, CodigoArticulo, DescripcionArticulo, TipoArticulo;
		private float PrecioArticulo;
		private int DiasPrestamo, CantidadArticulo;
		private string FechaArticuloIngreso, FabricacionArticulo;
		private bool Disponibilidad;
		
		public string tituloarticulo {get {return TituloArticulo;} set {TituloArticulo = value;}}
		public string codigoarticulo {get {return CodigoArticulo;} set {CodigoArticulo = value;}}
		public string descripcionarticulo {get {return DescripcionArticulo;} set {DescripcionArticulo = value;}}
		public string tipoarticulo {get {return TipoArticulo;} set {TipoArticulo = value;}}
		public float precioarticulo {get {return PrecioArticulo;} set {PrecioArticulo = value;}}
		public int cantidadarticulo {get {return CantidadArticulo;} set {CantidadArticulo = value;}}
		public string fechaingresoarticulo {get {return FechaArticuloIngreso;} set {FechaArticuloIngreso = value;}}
		public string fabricacionarticulo {get {return FabricacionArticulo;} set {FabricacionArticulo = value;}}
		public bool disponibilidadarticulo {get {return Disponibilidad;} set {Disponibilidad = value;}}
		public int diasprestamo {get{return DiasPrestamo;} set{DiasPrestamo = value;}}
		
		public Articulos()
		{
			codigoarticulo = "000000001";
			tituloarticulo = "Articulo";
			descripcionarticulo = "Vacio";
			tipoarticulo = "Vacio";
			precioarticulo = 0.0f;
			cantidadarticulo = 0;
			fabricacionarticulo = DateTime.Now.ToString();
			disponibilidadarticulo = false;
			diasprestamo = 0;
			fechaingresoarticulo = DateTime.Now.ToShortDateString();
		}
		
		public Articulos(string a, string b, string c, string d, float e, int f, string g, bool h, int i) : this()
		{
			codigoarticulo = a;
			tituloarticulo = b;
			descripcionarticulo = c;
			tipoarticulo = d;
			precioarticulo = e;
			cantidadarticulo = f;
			fabricacionarticulo = g;
			disponibilidadarticulo = h;
			diasprestamo = i;
		}
		
		public Articulos(string a, string b, string c, string d, float e, int f, string g, bool h, int i, string j) : this()
		{
			codigoarticulo = a;
			tituloarticulo = b;
			descripcionarticulo = c;
			tipoarticulo = d;
			precioarticulo = e;
			cantidadarticulo = f;
			fabricacionarticulo = g;
			disponibilidadarticulo = h;
			diasprestamo = i;
			fechaingresoarticulo = j;
		}
		
		public override string ToString()
		{
			return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", TituloArticulo, CodigoArticulo, DescripcionArticulo, TipoArticulo, PrecioArticulo, CantidadArticulo, FechaArticuloIngreso, FabricacionArticulo, Disponibilidad, DiasPrestamo);
		}

	}
}
