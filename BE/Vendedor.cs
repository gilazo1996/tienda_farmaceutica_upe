﻿using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Vendedor : Usuario
    {
        public Vendedor()
        {
            this.Rol = RolUsuario.Vendedor;
        }
    }
}
