using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleFactura
    {
		private long _idDetalleFactura;

		public long IdDetalleFactura
		{
			get { return _idDetalleFactura; }
			set { _idDetalleFactura = value; }
		}


		private Farmaco _farmaco;

		public Farmaco Farmaco
		{
			get { return _farmaco; }
			set { _farmaco = value; }
		}

		private int _cantidad;

		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}

		private double _subtotal;

		public double Subtotal
		{
			get { return _subtotal; }
			set { _subtotal = value; }
		}

		private Factura _factura;

		public Factura Factura
		{
			get { return _factura; }
			set { _factura = value; }
		}

        public DetalleFactura()
        {
			this.Farmaco = new Farmaco();
			this.Factura = new Factura();
        }
    }
}
