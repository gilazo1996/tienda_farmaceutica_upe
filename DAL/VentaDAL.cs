using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class VentaDAL
    {
        private Conexion conexion = new Conexion();

        public bool RegistrarVenta(int idVendedor, int? idCliente, int idMetodoPago, List<ProductoSeleccionado> productos)
        {
            try
            {
                // Calcular el total de la venta
                decimal totalVenta = productos.Sum(p => p.Subtotal);

                // 1. Insertar la factura y obtener el ID generado
                string insertFactura = @"INSERT INTO factura (NroFactura, FechaEmision, id_Vendedor, id_Metodo_Pago, Total) 
                                        VALUES ('" + GenerarNroFactura() + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " + 
                                        idVendedor + ", " + idMetodoPago + ", " + totalVenta.ToString(System.Globalization.CultureInfo.InvariantCulture) + "); SELECT SCOPE_IDENTITY();";

                // Ejecutar la inserción de factura
                var resultadoFactura = conexion.LeerPorComando(insertFactura);
                
                if (resultadoFactura == null || resultadoFactura.Rows.Count == 0)
                {
                    return false;
                }

                int idFactura = Convert.ToInt32(resultadoFactura.Rows[0][0]);

                // 2. Insertar detalles de la factura y actualizar stock
                foreach (var producto in productos)
                {
                    // Obtener ID del fármaco por código usando stored procedure
                    SqlParameter[] parametros = new SqlParameter[]
                    {
                        new SqlParameter("@CodigoInventario", producto.Codigo)
                    };

                    var resultadoFarmaco = conexion.LeerPorStoreProcedure("sp_Obtener_ID_Farmaco_Por_Codigo", parametros);
                    
                    if (resultadoFarmaco == null || resultadoFarmaco.Rows.Count == 0)
                    {
                        throw new Exception($"No se encontró el fármaco con código: {producto.Codigo}");
                    }

                    int idFarmaco = Convert.ToInt32(resultadoFarmaco.Rows[0][0]);

                    // Insertar detalle de factura
                    string insertDetalle = $@"INSERT INTO detalle_factura (id_Factura, id_Farmaco, CantidadSeleccionada, SubTotal) 
                                            VALUES ({idFactura}, {idFarmaco}, {producto.Cantidad}, {producto.Subtotal.ToString(System.Globalization.CultureInfo.InvariantCulture)})";

                    int resultadoDetalle = conexion.EscribirPorComando(insertDetalle);
                    
                    if (resultadoDetalle <= 0)
                    {
                        throw new Exception("Error al insertar detalle de factura");
                    }

                    // Actualizar stock
                    string updateStock = $"UPDATE farmaco SET Stock = Stock - {producto.Cantidad} WHERE id_Farmaco = {idFarmaco}";
                    int resultadoStock = conexion.EscribirPorComando(updateStock);
                    
                    if (resultadoStock <= 0)
                    {
                        throw new Exception("Error al actualizar el stock");
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en DAL: " + ex.Message);
                return false;
            }
        }

        private string GenerarNroFactura()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }

    
    public class ProductoSeleccionado
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}
