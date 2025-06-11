using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class UsuarioBE
    {
        public string _email;
        public string _password;
        public string _nickname;
        public string _nombre;
        public string _apellido;
        public char _dni;
        public string _genero;
        public string _nroCelular;
        public DateTime _fechaNacimiento;
        public int _idEstado;
    }
}
