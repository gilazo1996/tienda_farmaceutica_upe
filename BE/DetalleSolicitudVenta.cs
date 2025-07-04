using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleSolicitudVenta
    {
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

		private SolicitudVenta _solicitud;

		public SolicitudVenta Solicitud
		{
			get { return _solicitud; }
			set { _solicitud = value; }
		}

        public DetalleSolicitudVenta()
        {
			this.Farmaco = new Farmaco();
			this.Solicitud = new SolicitudVenta();
        }
    }
}
