using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Factura
    {
		private int _nroFactura;

		public int NroFactura
		{
			get { return _nroFactura; }
			set { _nroFactura = value; }
		}

		private DateTime _fechaEmision;

		public DateTime FechaEmision
		{
			get { return _fechaEmision; }
			set { _fechaEmision = value; }
		}

		private string _formaDePago;

		public string FormaDePago
		{
			get { return _formaDePago; }
			set { _formaDePago = value; }
		}

		private double _total;

		public double Total
		{
			get { return _total; }
			set { _total = value; }
		}

		private Vendedor _vendedor;

		public Vendedor Vendedor
		{
			get { return _vendedor; }
			set { _vendedor = value; }
		}

		private List<DetalleFactura> _listaDetallesFactura;

		public List<DetalleFactura> ListaDetallesFactura
		{
			get { return _listaDetallesFactura; }
			set { _listaDetallesFactura = value; }
		}

		public Factura()
        {
			this.Vendedor = new Vendedor();
			this.ListaDetallesFactura = new List<DetalleFactura>();
        }
    }
}
