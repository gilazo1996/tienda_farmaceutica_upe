using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL dal = new UsuarioDAL();

        public bool ValidarUsuario(string email, string password)
        {
            return dal.ValidarUsuario(email, password);
        }

        public string ObtenerTipoUsuario(string email, string password)
        {
            return dal.ObtenerTipoUsuario(email, password);
        }
    }
}
