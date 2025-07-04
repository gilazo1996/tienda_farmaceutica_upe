using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Farmaceutico : Usuario
    {
		private string _matricula;

		public string Matricula
		{
			get { return _matricula; }
			set { _matricula = value; }
		}

        public Farmaceutico()
        {
            this.Rol = RolUsuario.Farmaceutico;
        }
    }
}
