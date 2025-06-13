using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class VentaBLL
    {
        private VentaDAL dal = new VentaDAL();

        public bool RegistrarVenta(int idVendedor, int? idCliente, int idMetodoPago, List<ProductoSeleccionado> productos)
        {
            return dal.RegistrarVenta(idVendedor, idCliente, idMetodoPago, productos);
        }
    }
}
