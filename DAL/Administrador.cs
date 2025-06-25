using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Administrador
    {
        public BE.Usuario BuscarUsuario(string nombreUsuario)
        {
            Conexion conexion = new Conexion();
            BE.Usuario unUsuario = null;

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@NombreUsuario", nombreUsuario)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_buscar_usuario", parametros);

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

        public List<BE.Usuario> ListarUsuarios()
        {
            List<BE.Usuario> listaUsuarios = new List<BE.Usuario>();
            Conexion conexion = new Conexion();

            DataTable dt = conexion.LeerPorStoreProcedure("sp_listar_usuarios");

            foreach (DataRow row in dt.Rows)
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

                unUsuario.Nombre = row["Nombre"].ToString();
                unUsuario.Apellido = row["Apellido"].ToString();
                unUsuario.NombreUsuario = row["NombreUsuario"].ToString();
                unUsuario.Contraseña = row["Contraseña"].ToString();
                unUsuario.Cuil = row["CUIL"].ToString();
                unUsuario.Email = row["Email"].ToString();
                unUsuario.Teléfono = row["Telefono"].ToString();

                listaUsuarios.Add(unUsuario);
            }

            return listaUsuarios;
        }
    }
}
