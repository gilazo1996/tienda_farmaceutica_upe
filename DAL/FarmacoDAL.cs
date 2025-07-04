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
            DataRow row = null;

            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@CodigoInventario", codigo)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Obtener_Farmaco_Por_Codigo", parametros);

            if (dt.Rows.Count > 0)
                row = dt.Rows[0];
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
                        NroTelefono = row["TelefonoProveedor"].ToString(),  // Cambié a NroTelefono
                        Email = row["EmailProveedor"].ToString(),
                        Cuit = row["CUITProveedor"].ToString()
                    }
                };
            return farmaco;
        }
    }
    
}
