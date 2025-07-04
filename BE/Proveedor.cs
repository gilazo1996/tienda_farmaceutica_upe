using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Proveedor
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _nroTelefono;

		public string NroTelefono
		{
			get { return _nroTelefono; }
			set { _nroTelefono = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private string _cuit;

		public string Cuit
		{
			get { return _cuit; }
			set { _cuit = value; }
		}

		private string _personaContacto;

		public string PersonaContacto
		{
			get { return _personaContacto; }
			set { _personaContacto = value; }
		}

		private List<Farmaco> _farmacosSuministrados;

		public List<Farmaco> FarmacosSuministrados
		{
			get { return _farmacosSuministrados; }
			set { _farmacosSuministrados = value; }
		}

        public Proveedor()
        {
			this.FarmacosSuministrados = new List<Farmaco>();
        }
    }
}
