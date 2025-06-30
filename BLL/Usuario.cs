using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        public BE.Usuario IniciarSesion(string usuario, string contrasenia)
        {
            DAL.Usuario DALUsuario = new DAL.Usuario();

            if (usuario == "" || contrasenia == "")
                throw new Exception("Debe ingresar tanto el usuario como la contraseña.");

            BE.Usuario BEUsuario = DALUsuario.IniciarSesion(usuario);

            if (BEUsuario == null)
                throw new Exception("El usuario ingresado no existe.");

            string contraseniaHasheada = BLL.Seguridad.HashearContrasenia(contrasenia);

            if(BEUsuario.Contrasenia != contraseniaHasheada)
                throw new Exception("Usuario o contraseña incorrectos.");

            return BEUsuario;
        }
    }
}
