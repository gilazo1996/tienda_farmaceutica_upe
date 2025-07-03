using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VentaDAL
    {
        public bool RegistrarVenta(int idVendedor, int? idCliente, int idMetodoPago, List<ProductoSeleccionado> productos)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["FarmaceuticaDB"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    SqlTransaction transaction = conn.BeginTransaction();
            //    try
            //    {
            //        // 1. Insertar en factura
            //        string insertFactura = "INSERT INTO factura (nro_factura, fecha_emision, hora_emision, id_vendedor, id_cliente, id_metodo_pago, id_estado_factura) " +
            //                               "OUTPUT INSERTED.id VALUES (@nro, @fecha, @hora, @vendedor, @cliente, @metodo, 1)";
            //        int idFactura;
            //        using (SqlCommand cmd = new SqlCommand(insertFactura, conn, transaction))
            //        {
            //            cmd.Parameters.AddWithValue("@nro", GenerarNroFactura());
            //            cmd.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
            //            cmd.Parameters.AddWithValue("@hora", DateTime.Now.TimeOfDay);
            //            cmd.Parameters.AddWithValue("@vendedor", idVendedor);
            //            cmd.Parameters.AddWithValue("@cliente", (object)idCliente ?? DBNull.Value);
            //            cmd.Parameters.AddWithValue("@metodo", idMetodoPago);
            //            idFactura = (int)cmd.ExecuteScalar();
            //        }

            //        // 2. Insertar detalles y actualizar stock
            //        foreach (var p in productos)
            //        {
            //            // Buscar id_farmaco por código
            //            int idFarmaco = ObtenerIdFarmacoPorCodigo(p.Codigo, conn, transaction);

            //            // Insertar detalle_factura
            //            string insertDetalle = "INSERT INTO detalle_factura (id_factura, id_farmaco, cantidad, subtotal, total) " +
            //                                   "VALUES (@factura, @farmaco, @cantidad, @subtotal, @total)";
            //            using (SqlCommand cmd = new SqlCommand(insertDetalle, conn, transaction))
            //            {
            //                cmd.Parameters.AddWithValue("@factura", idFactura);
            //                cmd.Parameters.AddWithValue("@farmaco", idFarmaco);
            //                cmd.Parameters.AddWithValue("@cantidad", p.Cantidad);
            //                cmd.Parameters.AddWithValue("@subtotal", p.Subtotal);
            //                cmd.Parameters.AddWithValue("@total", p.Subtotal); 
            //                cmd.ExecuteNonQuery();
            //            }

            //            // Actualizar stock
            //            string updateStock = "UPDATE farmaco SET stock = stock - @cantidad WHERE id = @idFarmaco";
            //            using (SqlCommand cmd = new SqlCommand(updateStock, conn, transaction))
            //            {
            //                cmd.Parameters.AddWithValue("@cantidad", p.Cantidad);
            //                cmd.Parameters.AddWithValue("@idFarmaco", idFarmaco);
            //                cmd.ExecuteNonQuery();
            //            }
            //        }

            //        transaction.Commit();
            //        return true;
            //    }
            //    catch (Exception ex)
            //    {
            //        transaction.Rollback();
            //        System.Windows.Forms.MessageBox.Show("Error en DAL: " + ex.Message); // <-- Agrega esta línea
                    return false;
            //    }
            //}
        }

        private int ObtenerIdFarmacoPorCodigo(string codigo, SqlConnection conn, SqlTransaction transaction)
        {
            string query = "SELECT id FROM farmaco WHERE codigo_farmaco = @codigo";
            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                return (int)cmd.ExecuteScalar();
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
