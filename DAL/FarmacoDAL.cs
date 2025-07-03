using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using BE;

namespace DAL
{
    public class FarmacoDAL
    {
        public Farmaco ObtenerFarmacoPorCodigo(string codigo)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["FarmaceuticaDB"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    using (SqlCommand cmd = new SqlCommand("sp_ObtenerFarmacoPorCodigo", conn))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@codigo_farmaco", codigo);

            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                return new Farmaco
            //                {
            //                    Id = reader.GetInt32(0),
            //                    NombreComercial = reader.GetString(1),
            //                    CodigoFarmaco = reader.GetString(2),
            //                    PrecioUnidad = reader.GetDecimal(3),
            //                    Stock = reader.GetInt32(4)
            //                };
            //            }
            //        }
            //    }
            //}
            return null;
        }
    }
    
}
