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
    public class Usuario
    {
        public BE.Usuario IniciarSesion(string usuario)
        {
            Conexion conexion = new Conexion();
            BE.Usuario unUsuario = null;
            DataRow row = null;

            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@Nombreusuario", usuario)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Iniciar_Sesion", parametros);
            
            if (dt.Rows.Count > 0)
            {
                row = dt.Rows[0];
                unUsuario = MapearUsuario(row);
            }

            return unUsuario;
        }

        private BE.Usuario MapearUsuario(DataRow row)
        {
            BE.Usuario unUsuario = null;

            if (row["Rol"].ToString() == "1")
                unUsuario = new BE.Administrador();
            else if (row["Rol"].ToString() == "2")
                unUsuario = new BE.Farmaceutico();
            else if (row["Rol"].ToString() == "3")
                unUsuario = new BE.Gerente();
            else if (row["Rol"].ToString() == "4")
                unUsuario = new BE.Vendedor();

            unUsuario.IdUsuario = long.Parse(row["id_Usuario"].ToString());
            unUsuario.Nombre = row["Nombre"].ToString();
            unUsuario.Apellido = row["Apellido"].ToString();
            unUsuario.NombreUsuario = row["NombreUsuario"].ToString();
            unUsuario.Contrasenia = row["Contrasenia"].ToString();
            unUsuario.CUIL = row["CUIL"].ToString();
            unUsuario.Email = row["Email"].ToString();
            unUsuario.Telefono = row["Telefono"].ToString();
            if (unUsuario is BE.Farmaceutico farmaceutico)
                farmaceutico.Matricula = row["Matricula"].ToString();

            return unUsuario;
        }
    }
}
