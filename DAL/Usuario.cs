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
        public BE.Usuario IniciarSesion(string usuario, string contraseña)
        {
            Conexion conexion = new Conexion();
            BE.Usuario unUsuario = null;

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombreusuario", usuario),
                new SqlParameter("@Contraseña", contraseña)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_iniciar_sesion", parametros);

            foreach (DataRow row in dt.Rows)
            {

                if (row["Rol"].ToString() == "1")
                    unUsuario = new BE.Administrador();
                else if (row["Rol"].ToString() == "2")
                    unUsuario = new BE.Farmaceutico();
                else if (row["Rol"].ToString() == "3")
                    unUsuario = new BE.Gerente();
                else if (row["Rol"].ToString() == "4")
                    unUsuario = new BE.Vendedor();

                unUsuario.Nombre = row["Nombre"].ToString();
                unUsuario.Apellido = row["Apellido"].ToString();
                unUsuario.NombreUsuario = row["NombreUsuario"].ToString();
                unUsuario.Contraseña = row["Contraseña"].ToString();
                unUsuario.Cuil = row["CUIL"].ToString();
                unUsuario.Email = row["Email"].ToString();
                unUsuario.Teléfono = row["Telefono"].ToString();
            }

            return unUsuario;
        }
    }
}
