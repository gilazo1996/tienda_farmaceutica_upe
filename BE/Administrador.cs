﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Administrador : Usuario
    {
        public Administrador()
        {
            this.Rol = RolUsuario.Administrador;
        }
    }
}
