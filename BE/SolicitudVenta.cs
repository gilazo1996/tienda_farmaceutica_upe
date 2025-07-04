using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SolicitudVenta
    {
		public enum EstadoSolicitud
		{
			Aceptada = 1,
			Rechazada = 2,
			Pendiente = 3
		}

		private long _idSolicitud;

		public long IdSolicitud
		{
			get { return _idSolicitud; }
			set { _idSolicitud = value; }
		}


		private DateTime _fechaSolicitud;

		public DateTime FechaSolicitud
		{
			get { return _fechaSolicitud; }
			set { _fechaSolicitud = value; }
		}

		private EstadoSolicitud _estado;

		public EstadoSolicitud Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		private Vendedor _solicitante;

		public Vendedor Solicitante
		{
			get { return _solicitante; }
			set { _solicitante = value; }
		}

		private List<DetalleSolicitudVenta> _listaDetalleSolicitudVenta;

		public List<DetalleSolicitudVenta> ListaDetalleSolicitudVenta
		{
			get { return _listaDetalleSolicitudVenta; }
			set { _listaDetalleSolicitudVenta = value; }
		}

        public SolicitudVenta()
        {
			this.Solicitante = new Vendedor();
			this.ListaDetalleSolicitudVenta = new List<DetalleSolicitudVenta>();
        }
    }
}
