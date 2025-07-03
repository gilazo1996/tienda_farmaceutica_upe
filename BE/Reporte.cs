using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Reporte
    {
		private int _numReporte;

		public int NumReporte
		{
			get { return _numReporte; }
			set { _numReporte = value; }
		}

		private DateTime _fechaCreacion;

		public DateTime FechaCreacion
		{
			get { return _fechaCreacion; }
			set { _fechaCreacion = value; }
		}

		private List<DetalleReporte> _listaDetallesReporte;

		public List<DetalleReporte> ListaDetallesReporte
		{
			get { return _listaDetallesReporte; }
			set { _listaDetallesReporte = value; }
		}

        public Reporte()
        {
			this.ListaDetallesReporte = new List<DetalleReporte>();
        }
    }
}
