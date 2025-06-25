using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public abstract class Usuario
	{
        public enum RolUsuario
        {
            Administrador = 1,
            Farmacéutico = 2,
            Gerente = 3,
            Vendedor = 4
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

		private string _nombreUsuario;

		public string NombreUsuario
		{
			get { return _nombreUsuario; }
			set { _nombreUsuario = value; }
		}

        private string _contraseña;

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        private string _cuil;

		public string Cuil
		{
			get { return _cuil; }
			set { _cuil = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private string _teléfono;

		public string Teléfono
		{
			get { return _teléfono; }
			set { _teléfono = value; }
		}

		private RolUsuario _rol;

		public RolUsuario Rol
		{
			get { return _rol; }
			set { _rol = value; }
		}
    }
}
