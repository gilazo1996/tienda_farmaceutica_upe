using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Gerente : Usuario
    {
        public Gerente()
        {
            this.Rol = RolUsuario.Gerente;
        }
    }
}
