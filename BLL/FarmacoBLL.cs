using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class FarmacoBLL
    {
        private FarmacoDAL dal = new FarmacoDAL();

        public Farmaco ObtenerFarmacoPorCodigo(string codigo)
        {
            // Aquí puedes agregar validaciones o lógica de negocio si es necesario
            return dal.ObtenerFarmacoPorCodigo(codigo);
        }
    }
}
