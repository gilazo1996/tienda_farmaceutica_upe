using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Farmaco
    {
        public int Id { get; set; }
        public string NombreComercial { get; set; }
        public string CodigoFarmaco { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int Stock { get; set; }
    }
}
