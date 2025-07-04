using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using BE;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class FarmacoDAL
    {
        public Farmaco ObtenerFarmacoPorCodigo(string codigo)
        {
            Conexion conexion = new Conexion();
            BE.Farmaco farmaco = null;

            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@CodigoInventario", codigo)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Obtener_Farmaco_Por_Codigo", parametros);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                farmaco = new Farmaco
                {
                    NombreComercial = row["NombreComercial"].ToString(),
                    CodigoInventario = row["CodigoInventario"].ToString(),
                    FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]),
                    PrecioUnidad = Convert.ToDouble(row["PrecioUnidad"]),
                    RequiereReceta = Convert.ToBoolean(row["RequiereReceta"]),
                    Stock = Convert.ToInt32(row["Stock"]),
                    Proveedor = new Proveedor
                    {
                        Nombre = row["NombreProveedor"].ToString(),
                        NroTelefono = row["TelefonoProveedor"].ToString(),
                        Email = row["EmailProveedor"].ToString(),
                        Cuit = row["CUITProveedor"].ToString()
                    }
                };
            }
            return farmaco;
        }

        public bool EliminarFarmaco(string codigoInventario)
        {
            try
            {
                Conexion conexion = new Conexion();
                
                SqlParameter[] parametros = new SqlParameter[]
                {
                    conexion.crearParametro("@CodigoInventario", codigoInventario)
                };

                DataTable dt = conexion.LeerPorStoreProcedure("sp_Eliminar_Farmaco", parametros);
                
                if (dt.Rows.Count > 0)
                {
                    int resultado = Convert.ToInt32(dt.Rows[0]["Resultado"]);
                    string mensaje = dt.Rows[0]["Mensaje"].ToString();
                    
                    if (resultado == 0)
                    {
                        throw new Exception(mensaje);
                    }
                    
                    return resultado == 1;
                }
                
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar fármaco en la DAL: " + ex.Message);
            }
        }

        public bool ActualizarFarmaco(Farmaco farmaco)
        {
            try
            {
                Conexion conexion = new Conexion();
                
                SqlParameter[] parametros = new SqlParameter[]
                {
                    conexion.crearParametro("@CodigoInventario", farmaco.CodigoInventario),
                    conexion.crearParametro("@NombreComercial", farmaco.NombreComercial),
                    conexion.crearParametro("@PrecioUnidad", farmaco.PrecioUnidad),
                    conexion.crearParametro("@Stock", farmaco.Stock),
                    conexion.crearParametro("@FechaVencimiento", farmaco.FechaVencimiento),
                    conexion.crearParametro("@RequiereReceta", farmaco.RequiereReceta)
                };

                int filasAfectadas = conexion.EscribirPorStoreProcedure("sp_Actualizar_Farmaco", parametros);
                
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar fármaco en la DAL: " + ex.Message);
            }
        }
    }
    
}
