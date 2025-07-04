using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleReporte
    {
		private Factura _factura;

		public Factura Factura
		{
			get { return _factura; }
			set { _factura = value; }
		}

		private Reporte _reporte;

		public Reporte Reporte
		{
			get { return _reporte; }
			set { _reporte = value; }
		}

        public DetalleReporte()
        {
			this.Factura = new Factura();
			this.Reporte = new Reporte();
        }
    }
}
