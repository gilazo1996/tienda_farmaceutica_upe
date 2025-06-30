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
            Farmaceutico = 2,
            Gerente = 3,
            Vendedor = 4
        }

		private long _idUsuario;

		public long IdUsuario
		{
			get { return _idUsuario; }
			set { _idUsuario = value; }
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

        private string _contrasenia;

        public string Contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }

        private string _cuil;

		public string CUIL
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

		private string _telefono;

		public string Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}

		private RolUsuario _rol;

		public RolUsuario Rol
		{
			get { return _rol; }
			set { _rol = value; }
		}
    }
}
