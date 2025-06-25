using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Administrador
    {
        private DAL.Administrador administrador = new DAL.Administrador();

        public BE.Usuario BuscarUsuario(string nombreUsuario)
        { 
            BE.Usuario unUsuario = administrador.BuscarUsuario(nombreUsuario);

            if (unUsuario == null)
                throw new Exception("No se ha encontrado ningún usuario.");
                
            return unUsuario;
        }

        public List<BE.Usuario> ListarUsuarios()
        {
            List<BE.Usuario> listaUsuarios = new List<BE.Usuario>();

            listaUsuarios = administrador.ListarUsuarios();

            if(listaUsuarios.Count() == 0)
                throw new Exception("No encontraron usuarios.");

            return listaUsuarios;
        }
    }
}
