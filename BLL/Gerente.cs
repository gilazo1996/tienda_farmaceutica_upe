using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Gerente
    {
        DAL.Gerente DALGerente = new DAL.Gerente();

        public List<BE.Factura> ListarFacturas()
        {
            List<BE.Factura> listaFacturas = new List<BE.Factura>();

            listaFacturas = DALGerente.ListarFacturas();

            if (listaFacturas.Count() == 0)
                throw new Exception("No se encontraron facturas registradas.");

            return listaFacturas;
        }

        public List<DetalleFactura> ListarDetalleFactura(long idFactura)
        {
            List<BE.DetalleFactura> listarDetalle = new List<BE.DetalleFactura>();

            listarDetalle = DALGerente.ListarDetallesFactura(idFactura);

            if (listarDetalle.Count() == 0)
                throw new Exception("No se encontraron facturas registradas.");

            return listarDetalle;
        }

        public List<SolicitudVenta> ListarSolicitudes()
        {
            List<BE.SolicitudVenta> listaSolicitudes = new List<BE.SolicitudVenta>();

            listaSolicitudes = DALGerente.ListarSolicitudes();

            if (listaSolicitudes.Count() == 0)
                throw new Exception("No se encontraron solicitudes de venta registradas.");

            return listaSolicitudes;
        }

        public List<DetalleSolicitudVenta> ListarDetalleSolicitud(long idSolicitud)
        {
            List<BE.DetalleSolicitudVenta> listarDetalle = new List<BE.DetalleSolicitudVenta>();

            listarDetalle = DALGerente.ListarDetalleSolicitud(idSolicitud);

            if (listarDetalle.Count() == 0)
                throw new Exception("No se encontraron facturas registradas.");

            return listarDetalle;
        }

        public List<Factura> BuscarFacturasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<BE.Factura> listaFacturas = new List<BE.Factura>();

            if(fechaInicio > fechaFin)
                throw new Exception("La fecha de inicio no puede ser mayor a la fecha de fin.");

            listaFacturas = DALGerente.BuscarFacturasPorFecha(fechaInicio, fechaFin);

            if (listaFacturas.Count() == 0)
                throw new Exception("No se encontraron facturas en el rango de fechas indicado.");

            return listaFacturas;
        }
    }
}
