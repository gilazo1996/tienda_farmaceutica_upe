using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Gerente
    {
        public List<BE.Factura> ListarFacturas()
        {
            List<BE.Factura> listaFacturas = new List<BE.Factura>();
            DAL.Conexion conexion = new DAL.Conexion();

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Listar_Facturas");

            foreach (DataRow row in dt.Rows)
            {
                BE.Factura factura = MapearFactura(row);

                if (factura != null)
                    listaFacturas.Add(factura);
            }

            return listaFacturas;
        }

        public List<BE.DetalleFactura> ListarDetallesFactura(long idFactura)
        {
            List<BE.DetalleFactura> listaDetalles = new List<BE.DetalleFactura>();
            DAL.Conexion conexion = new DAL.Conexion();

            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@IdFactura", idFactura)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Listar_Detalles_Factura", parametros);

            foreach (DataRow row in dt.Rows)
            {
                BE.DetalleFactura detalle = MapearDetalleFactura(row);

                if (detalle != null)
                    listaDetalles.Add(detalle);
            }

            return listaDetalles;
        }

        public List<SolicitudVenta> ListarSolicitudes()
        {
            List<BE.SolicitudVenta> listaSolicitudes = new List<SolicitudVenta>();
            DAL.Conexion conexion = new DAL.Conexion();

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Listar_Solicitudes_Venta");

            foreach (DataRow row in dt.Rows)
            {
                BE.SolicitudVenta solicitud = MapearSolicitud(row);

                if (solicitud != null)
                    listaSolicitudes.Add(solicitud);
            }

            return listaSolicitudes;
        }

        private SolicitudVenta MapearSolicitud(DataRow row)
        {
            BE.SolicitudVenta solicitud = new BE.SolicitudVenta();

            solicitud.IdSolicitud = (long)row["id_Solicitud_Venta"];
            solicitud.FechaSolicitud = DateTime.Parse(row["FechaSolicitud"].ToString());
            solicitud.Estado = (BE.SolicitudVenta.EstadoSolicitud)row["EstadoSolicitud"];
            solicitud.Solicitante.Nombre = row["NombreSolicitante"].ToString();
            solicitud.Solicitante.Apellido = row["ApellidoSolicitante"].ToString();
            solicitud.Solicitante.CUIL = row["CUILSolicitante"].ToString();

            return solicitud;
        }

        public List<DetalleSolicitudVenta> ListarDetalleSolicitud(long idSolicitud)
        {
            List<BE.DetalleSolicitudVenta> listaDetalles = new List<BE.DetalleSolicitudVenta>();
            DAL.Conexion conexion = new DAL.Conexion();

            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@IdSolicitud", idSolicitud)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Listar_Detalles_Solicitud", parametros);

            foreach (DataRow row in dt.Rows)
            {
                BE.DetalleSolicitudVenta detalle = MapearDetalleSolicitud(row);

                if (detalle != null)
                    listaDetalles.Add(detalle);
            }

            return listaDetalles;
        }

        public List<Factura> BuscarFacturasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<BE.Factura> listaFacturas = new List<BE.Factura>();
            DAL.Conexion conexion = new DAL.Conexion();

            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@FechaInicio", fechaInicio),
                conexion.crearParametro("@FechaFin", fechaFin)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Buscar_Facturas_Por_Fechas", parametros);

            foreach (DataRow row in dt.Rows)
            {
                BE.Factura factura = MapearFactura(row);

                if (factura != null)
                    listaFacturas.Add(factura);
            }

            return listaFacturas;
        }

        private DetalleSolicitudVenta MapearDetalleSolicitud(DataRow row)
        {
            BE.DetalleSolicitudVenta detalle = new BE.DetalleSolicitudVenta();

            detalle.Farmaco.CodigoInventario = row["CodigoInventario"].ToString();
            detalle.Farmaco.NombreComercial = row["NombreComercial"].ToString();
            detalle.Cantidad = (int)row["Cantidad"];

            return detalle;
        }

        public BE.Factura MapearFactura(DataRow row)
        {
            BE.Factura factura = new BE.Factura();

            factura.IdFactura = (long)row["id_Factura"];
            factura.NroFactura = row["NroFactura"].ToString();
            factura.FechaEmision = DateTime.Parse(row["FechaEmision"].ToString());
            factura.Total = (double)row["Total"];
            factura.MetodoDePago = row["MetodoPago"].ToString();
            factura.Vendedor.Nombre = row["NombreVendedor"].ToString();
            factura.Vendedor.Apellido = row["ApellidoVendedor"].ToString();
            factura.Vendedor.CUIL = row["CUILVendedor"].ToString();

            return factura;
        }

        private BE.DetalleFactura MapearDetalleFactura(DataRow row)
        {
            BE.DetalleFactura detalle = new BE.DetalleFactura();

            detalle.Farmaco.CodigoInventario = row["CodigoInventario"].ToString();
            detalle.Farmaco.NombreComercial = row["NombreComercial"].ToString();
            detalle.Cantidad = (int)row["CantidadSeleccionada"];
            detalle.Subtotal = (double)row["Subtotal"];

            return detalle;
        }
    }
}
