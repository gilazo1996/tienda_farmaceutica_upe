using BE;
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
        public int AgregarUsuario(BE.Usuario usuario)
        {
            Conexion conexion = new Conexion();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                conexion.crearParametro("@Nombre", usuario.Nombre),
                conexion.crearParametro("@Apellido", usuario.Apellido),
                conexion.crearParametro("@NombreUsuario", usuario.NombreUsuario),
                conexion.crearParametro("@Contrasenia", usuario.Contrasenia),
                conexion.crearParametro("@CUIL", usuario.CUIL),
                conexion.crearParametro("@Email", usuario.Email),
                conexion.crearParametro("@Telefono", usuario.Telefono),
                conexion.crearParametro("@Rol", (int)usuario.Rol)
            };

            if (usuario is BE.Farmaceutico farmaceutico)
                parametros.Add(conexion.crearParametro("@Matricula", farmaceutico.Matricula));

            int estado = conexion.EscribirPorStoreProcedure("sp_Agregar_Usuario", parametros.ToArray());

            return estado;
        }

        public BE.Usuario BuscarUsuario(string nombreUsuario)
        {
            Conexion conexion = new Conexion();
            BE.Usuario unUsuario = null;
            DataRow row = null;

            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@NombreUsuario", nombreUsuario)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Buscar_Usuario", parametros);

            if(dt.Rows.Count > 0)
                row = dt.Rows[0];
                unUsuario = MapearUsuario(row);

            return unUsuario;
        }

        public int EditarUsuario(BE.Usuario usuario)
        {
            Conexion conexion = new Conexion();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                conexion.crearParametro("@IdUsuario", usuario.IdUsuario),
                conexion.crearParametro("@Nombre", usuario.Nombre),
                conexion.crearParametro("@Apellido", usuario.Apellido),
                conexion.crearParametro("@NombreUsuario", usuario.NombreUsuario),
                conexion.crearParametro("@Contrasenia", usuario.Contrasenia),
                conexion.crearParametro("@CUIL", usuario.CUIL),
                conexion.crearParametro("@Email", usuario.Email),
                conexion.crearParametro("@Telefono", usuario.Telefono)
            };

            if (usuario is BE.Farmaceutico farmaceutico)
                parametros.Add(conexion.crearParametro("@Matricula", farmaceutico.Matricula));

            int estado = conexion.EscribirPorStoreProcedure("sp_Editar_Usuario", parametros.ToArray());

            return estado;
        }

        public int EliminarUsuario(BE.Usuario usuario)
        {
            Conexion conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@IdUsuario", usuario.IdUsuario)
            };

            int estado = conexion.EscribirPorStoreProcedure("sp_Eliminar_Usuario", parametros);

            return estado;
        }

        public int CambiarRolUsuario(BE.Usuario usuario)
        {
            Conexion conexion = new Conexion();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                conexion.crearParametro("@IdUsuario", usuario.IdUsuario),
                conexion.crearParametro("@NuevoRol", (int)usuario.Rol)
            };

            if (usuario is BE.Farmaceutico farmaceutico)
                parametros.Add(conexion.crearParametro("@Matricula", farmaceutico.Matricula));

            int estado = conexion.EscribirPorStoreProcedure("sp_Cambiar_Rol_Usuario", parametros.ToArray());

            return estado;
        }
        public List<BE.Usuario> ListarUsuarios()
        {
            List<BE.Usuario> listaUsuarios = new List<BE.Usuario>();
            Conexion conexion = new Conexion();

            DataTable dt = conexion.LeerPorStoreProcedure("sp_Listar_Usuarios");

            foreach (DataRow row in dt.Rows)
            {
                BE.Usuario unUsuario = null;

                unUsuario = MapearUsuario(row);

                listaUsuarios.Add(unUsuario);
            }

            return listaUsuarios;
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
            if(unUsuario is BE.Farmaceutico farmaceutico)
                farmaceutico.Matricula = row["Matricula"].ToString();

            return unUsuario;
        }
    }
}
