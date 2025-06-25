using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        public BE.Usuario IniciarSesion(string usuario, string contraseña)
        {
            DAL.Usuario DALUsuario = new DAL.Usuario();
            BE.Usuario BEUsuario = DALUsuario.IniciarSesion(usuario, contraseña);

            if (BEUsuario == null)
                throw new Exception("Usuario o contraseña incorrectos.");

            return BEUsuario;
        }
    }
}
