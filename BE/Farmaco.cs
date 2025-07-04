using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Farmaco
    {
        private string _nombreComercial;

        public string NombreComercial
        {
            get { return _nombreComercial; }
            set { _nombreComercial = value; }
        }

        private string _codigoInventario;

		public string CodigoInventario
		{
			get { return _codigoInventario; }
			set { _codigoInventario = value; }
		}

		private DateTime _fechaVencimiento;

		public DateTime FechaVencimiento
		{
			get { return _fechaVencimiento; }
			set { _fechaVencimiento = value; }
		}

		private double _precioUnidad;

		public double PrecioUnidad
		{
			get { return _precioUnidad; }
			set { _precioUnidad = value; }
		}

		private bool _requiereReceta;

		public bool RequiereReceta
		{
			get { return _requiereReceta; }
			set { _requiereReceta = value; }
		}

		private int _stock;

		public int Stock
		{
			get { return _stock; }
			set { _stock = value; }
		}

		private Proveedor _proveedor;

		public Proveedor Proveedor
		{
			get { return _proveedor; }
			set { _proveedor = value; }
		}

        public Farmaco()
        {
			
			this.Proveedor = new Proveedor();	
        }
    }
}
