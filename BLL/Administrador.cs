using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Administrador
    {
        private DAL.Administrador DALAdmin = new DAL.Administrador();

        public bool AgregarUsuario(BE.Usuario usuario)
        {
            if (usuario.Nombre == "" || usuario.Apellido == "" || usuario.NombreUsuario == "" || usuario.Contrasenia == "" || usuario.CUIL == "" || usuario.Email == "" || usuario.Telefono == "")
                throw new Exception("Debe completar toda la informacion del usuario.");
            else if (usuario is BE.Farmaceutico farmaceutico && farmaceutico.Matricula == "")
                throw new Exception("Debe completar toda la informacion del usuario.");

            //Agregar validacion con regex para cada campo

            string contraseniaHasheada = BLL.Seguridad.HashearContrasenia(usuario.Contrasenia);

            usuario.Contrasenia = contraseniaHasheada;

            int estado = DALAdmin.AgregarUsuario(usuario);

            if (estado > 0)
                return true;

            return false;
        }

        public BE.Usuario BuscarUsuario(string nombreUsuario)
        {
            if (nombreUsuario == "")
                throw new Exception("Debe ingresar el nombre de usuario.");

            //Agregar validacion con regex para el nombre de usuario

            BE.Usuario unUsuario = DALAdmin.BuscarUsuario(nombreUsuario);

            if (unUsuario == null)
                throw new Exception("No se ha encontrado al usuario ingresado.");
                
            return unUsuario;
        }

        public bool EditarUsuario(BE.Usuario usuario)
        {
            if (usuario.Nombre == "" || usuario.Apellido == "" || usuario.NombreUsuario == "" || usuario.Contrasenia == "" || usuario.CUIL == "" || usuario.Email == "" || usuario.Telefono == "")
                throw new Exception("Debe completar toda la informacion del usuario.");
            else if (usuario is BE.Farmaceutico farmaceutico && farmaceutico.Matricula == "")
                throw new Exception("Debe completar toda la informacion del usuario.");

            //Agregar validacion con regex para cada campo

            string contraseniaHasheada = BLL.Seguridad.HashearContrasenia(usuario.Contrasenia);

            usuario.Contrasenia = contraseniaHasheada;

            int estado = DALAdmin.EditarUsuario(usuario);

            if (estado > 0)
                return true;

            return false;
        }

        public bool EliminarUsuario(BE.Usuario usuario)
        {
            if(usuario == null)
                throw new Exception("Debe buscar un usuario para poder eliminarlo.");

            int estado = DALAdmin.EliminarUsuario(usuario);

            if (estado > 0)
                return true;

            return false;
        }

        public bool CambiarRolUsuario(BE.Usuario usuario)
        {
            if (usuario == null)
                throw new Exception("Debe buscar un usuario para poder cambiar su rol.");

            int estado = DALAdmin.CambiarRolUsuario(usuario);

            if (estado > 0)
                return true;

            return false;
        }

        public List<BE.Usuario> ListarUsuarios()
        {
            List<BE.Usuario> listaUsuarios = new List<BE.Usuario>();


            listaUsuarios = DALAdmin.ListarUsuarios();

            if (listaUsuarios.Count() == 0)
                throw new Exception("No se encontraron usuarios ingresados.");

            foreach(BE.Usuario usuario in listaUsuarios)
            {
                string contraseniaHasheada = BLL.Seguridad.HashearContrasenia(usuario.Contrasenia);
                usuario.Contrasenia = contraseniaHasheada;
            }

            return listaUsuarios;
        }
    }
}
